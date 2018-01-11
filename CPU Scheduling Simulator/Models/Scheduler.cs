using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPU_Scheduling_Simulator.Helpers;

namespace CPU_Scheduling_Simulator.Models
{
    public class Scheduler
    {
        public SchedulerAlgorithm Algorithm { get; set; }

        public SchedulerStatus Status { get; set; }

        public int CurrentTime { get; set; }

        public double AverageWaitingTime { get; set; }

        public double AverageTurnaroundTime { get; set; }

        public double AverageResponseTime { get; set; }

        public double AverageWaitingProcesses { get; set; }

        public double AverageCPUUtilisation { get; set; }

        public IList<Process> ProcessesEnded { get; set; }

        public IList<Process> ProcessesList { get; set; }

        public IList<Process> ProcessesQueue { get; set; }

        public IList<Process> ProcessesOrder { get; set; }

        public IList<KeyTime> KeyTimes { get; set; }

        public Scheduler()
        {
            CurrentTime = 0;
            AverageResponseTime = AverageCPUUtilisation = AverageWaitingProcesses = AverageWaitingTime = AverageTurnaroundTime =  0;
            Status = SchedulerStatus.Off;
            ProcessesList  = new List<Process>();
            ProcessesQueue = new List<Process>();
            ProcessesOrder = new List<Process>();
            ProcessesEnded = new List<Process>();
            KeyTimes = new List<KeyTime>();
        }

        public void RemoveProcess(int id)
        {
            Process toBeRemovedFromList   = ProcessesList.FirstOrDefault(c => c.Id == id);
            Process toBeRemovedFromQueue  = ProcessesQueue.FirstOrDefault(c => c.Id == id);
            if (toBeRemovedFromList != null)
            {
                ProcessesList.Remove(toBeRemovedFromList);
                foreach (var process in ProcessesList)
                {
                    if (process.Id > id)
                    {
                        --process.Id; 
                    }
                }
            }
            if (toBeRemovedFromQueue != null)
            {
                ProcessesQueue.Remove(toBeRemovedFromQueue);
                foreach (var process in ProcessesQueue)
                {
                    if (process.Id > id)
                    {
                        --process.Id;
                    }
                }
            }
        }

        //FCFS = First Come First Serve
        public void solveFCFS()
        {
            CurrentTime = 0;
            Status = SchedulerStatus.On;
            ProcessesQueue = ProcessesList;
            //Queue Starts with ascending order of processes by Arrival Time. 
            ProcessesQueue = ProcessesQueue.OrderBy(c => c.ArrivalTime).ToList();

            //Load first Process
            while (ProcessesQueue[0].ArrivalTime > CurrentTime)
            {
                KeyTime keyTime = new KeyTime();
                keyTime.CpuOnLoad = false;
                keyTime.Process = null;
                keyTime.OngoingProcess = null;
                keyTime.OutgoingProcess = null;
                keyTime.Timestamp = CurrentTime;
                ++CurrentTime;;
                KeyTimes.Add(keyTime);
            }

            //First process comes at moment zero (special scenario)
            if (CurrentTime == 0 && ProcessesQueue[0].ArrivalTime == 0)
            {
                Process firstProcess = ProcessesQueue[0];
                ProcessesQueue.RemoveAt(0); //Remove selected process from the queue
                KeyTime keyTime = new KeyTime();
                keyTime.CpuOnLoad = true;
                keyTime.OutgoingProcess = null;
                keyTime.Timestamp = CurrentTime;

                firstProcess.LastEnterTime = CurrentTime;
                firstProcess.Status = ProcessStatus.OnCpu;
                keyTime.OngoingProcess = firstProcess;
                KeyTimes.Add(keyTime);
                ++CurrentTime;
                ++AverageCPUUtilisation;
            }

            //Continue processing 
            KeyTime currentKeyTime = new KeyTime();
            KeyTime lastKeyTime = KeyTimes[CurrentTime - 1];

            while (ProcessesQueue.Count > 0 || lastKeyTime.OngoingProcess != null || currentKeyTime.OngoingProcess != null)
            {
   
                currentKeyTime = new KeyTime();
                lastKeyTime = KeyTimes[CurrentTime - 1];
                currentKeyTime.Timestamp = CurrentTime;

                //

                //Last process action on current moment
                var lastOngoingProcessResult = CheckForProcessContinuity(CloneObject.CloneJson(lastKeyTime.OngoingProcess));

                //Process ongoing on the CPU. No replacements actions needed
                if (lastOngoingProcessResult != null && lastOngoingProcessResult.Item2 != null)
                {
                    currentKeyTime.OutgoingProcess = null;
                    currentKeyTime.OngoingProcess = lastOngoingProcessResult.Item2;
                    currentKeyTime.CpuOnLoad = true;
                    ++AverageCPUUtilisation;
                    if (currentKeyTime.OngoingProcess.ResponseTime == 0)
                        currentKeyTime.OngoingProcess.ResponseTime = CurrentTime;
                }
                else
                {
                    if (lastOngoingProcessResult != null) 
                    {
                        currentKeyTime.OutgoingProcess = lastOngoingProcessResult.Item1;
                    }

                    currentKeyTime.OngoingProcess = TryLoadProcessFromQueue();
                    if (currentKeyTime.OngoingProcess != null)
                    { ++AverageCPUUtilisation;
                        if (currentKeyTime.OngoingProcess.ResponseTime == 0)
                            currentKeyTime.OngoingProcess.ResponseTime = CurrentTime;
                    }

                }

                    KeyTimes.Add(currentKeyTime);
                    AverageWaitingProcesses += ProcessesQueue.Count;
                     ++CurrentTime;
            }

            Status = SchedulerStatus.Off;
    
        }

        //SJF = Shortest Job First
        public void solveSJF()
        {
            CurrentTime = 0;
            Status = SchedulerStatus.On;

            ProcessesQueue = ProcessesList;
            //Queue Starts with ascending order of processes by Arrival Time. 
            ProcessesQueue = ProcessesQueue.OrderBy(c => c.ArrivalTime).ThenBy(c => c.BurstTime).ToList();

            //Load first Process
            while (ProcessesQueue[0].ArrivalTime > CurrentTime)
            {
                KeyTime keyTime = new KeyTime();
                keyTime.CpuOnLoad = false;
                keyTime.Process = null;
                keyTime.OngoingProcess = null;
                keyTime.OutgoingProcess = null;
                keyTime.Timestamp = CurrentTime;
                ++CurrentTime;
                KeyTimes.Add(keyTime);

            }

            //First process comes at moment zero (special scenario)
            if (CurrentTime == 0 && ProcessesQueue[0].ArrivalTime == 0)
            {
                Process firstProcess = ProcessesQueue[0];
                ProcessesQueue.RemoveAt(0); //Remove selected process from the queue
                KeyTime keyTime = new KeyTime();
                keyTime.CpuOnLoad = true;
                keyTime.OutgoingProcess = null;
                keyTime.Timestamp = CurrentTime;

                firstProcess.LastEnterTime = CurrentTime;
                firstProcess.Status = ProcessStatus.OnCpu;
                keyTime.OngoingProcess = firstProcess;
                KeyTimes.Add(keyTime);
                ++CurrentTime;
            }

            //Continue processing 
            KeyTime currentKeyTime = new KeyTime();
            KeyTime lastKeyTime = KeyTimes[CurrentTime - 1];

            while (ProcessesQueue.Count > 0 || lastKeyTime.OngoingProcess != null || currentKeyTime.OngoingProcess != null)
            {

                currentKeyTime = new KeyTime();
                lastKeyTime = KeyTimes[CurrentTime - 1];
                currentKeyTime.Timestamp = CurrentTime;

                //Last process action on current moment
                var lastOngoingProcessResult = CheckForProcessContinuity(CloneObject.CloneJson(lastKeyTime.OngoingProcess));

                //Process ongoing on the CPU. No replacements actions needed
                if (lastOngoingProcessResult != null && lastOngoingProcessResult.Item2 != null)
                {
                    currentKeyTime.OutgoingProcess = null;
                    currentKeyTime.OngoingProcess = lastOngoingProcessResult.Item2;
                    currentKeyTime.CpuOnLoad = true;
                    if (currentKeyTime.OngoingProcess.ResponseTime == 0)
                        currentKeyTime.OngoingProcess.ResponseTime = CurrentTime;
                    ++AverageCPUUtilisation;
                }
                else
                {
                    if (lastOngoingProcessResult != null)
                    {
                        currentKeyTime.OutgoingProcess = lastOngoingProcessResult.Item1;
                       
                    }

                    currentKeyTime.OngoingProcess = TryLoadProcessFromQueue();
                    if (currentKeyTime.OngoingProcess != null)
                    {
                        ++AverageCPUUtilisation;
                        if (currentKeyTime.OngoingProcess.ResponseTime == 0)
                            currentKeyTime.OngoingProcess.ResponseTime = CurrentTime;
                    }
                }

                KeyTimes.Add(currentKeyTime);
                AverageWaitingProcesses += ProcessesQueue.Count;
                ++CurrentTime;
            }

            Status = SchedulerStatus.Off;
        }

        //RR = Round Robin
        public void solveRR()
        {
            
        }

        #region Data Computing



        public void ComputeData()
        {
               


            for (int i = 0; i < ProcessesEnded.Count; ++i)
            {
                AverageResponseTime += ProcessesEnded[i].ResponseTime;
                AverageWaitingTime += ProcessesEnded[i].WaitingTime;
                AverageTurnaroundTime += ProcessesEnded[i].FinishTime - ProcessesEnded[i].ArrivalTime ;
            }

            AverageResponseTime   /= ProcessesEnded.Count;
            AverageWaitingTime    /= ProcessesEnded.Count;
            AverageTurnaroundTime /= ProcessesEnded.Count;

            AverageWaitingProcesses /= (CurrentTime-2);
            AverageCPUUtilisation /= (CurrentTime-2);

        }




        #endregion



        #region Helper Methods

        private Process TryLoadProcessFromQueue()
        {
            if (ProcessesQueue.Count > 0)
            {
                if (Algorithm == SchedulerAlgorithm.FCFS)
                {
                    var processFromQueue = ProcessesQueue[0];


                    //Process can be loaded from queue
                    if (processFromQueue.ArrivalTime <= CurrentTime && processFromQueue.LastEnterTime == -1 ||
                        processFromQueue.LastExitTime + processFromQueue.IOTime <= CurrentTime)
                    {
                        ProcessesQueue.RemoveAt(0);
                        processFromQueue.Status = ProcessStatus.OnCpu;
                        processFromQueue.LastEnterTime = CurrentTime;
                          

                        return processFromQueue;
                    }
                }
                else if (Algorithm == SchedulerAlgorithm.SJF)
                {
                    int shortestJobAvailableDuration = int.MaxValue;
                    int it = 0;
                    int processFromQueuePosition = -1;
                    Process processFromQueue = null;

                    for (; it < ProcessesQueue.Count; it++)
                    {
                        Process p = ProcessesQueue[it];
                        if (((p.ArrivalTime <= CurrentTime && p.LastEnterTime == -1) ||(p.LastExitTime + p.IOTime <= CurrentTime && p.LastExitTime != -1)) &&
                            (p.BurstTime < p.RemainingDuration ? p.BurstTime : p.RemainingDuration) < shortestJobAvailableDuration)
                        {
                            processFromQueue = CloneObject.CloneJson(p);
                            processFromQueuePosition = it;
                            shortestJobAvailableDuration = p.BurstTime < p.RemainingDuration ? p.BurstTime : p.RemainingDuration;
                        }
                    }

                    if (processFromQueue != null)
                    {
                        ProcessesQueue.RemoveAt(processFromQueuePosition);
                        processFromQueue.Status = ProcessStatus.OnCpu;
                        processFromQueue.LastEnterTime = CurrentTime;



                        return processFromQueue;
                    }
                }
            }
            return null;
        }

        private Tuple<Process, Process> CheckForProcessContinuity(Process lastOngoingProcess)
        {
            Process p = lastOngoingProcess;
            Process outcomingProcess = null;
            Process ongoingProcess = null;

            //No process on the CPU
            if (p == null)
            {
                return null;
            }
            else
            {
                //Finish the process without pushing it to our queue
                if (p.RemainingDuration == 1 && (p.LastEnterTime + p.BurstTime >= CurrentTime || p.CPUBound))
                {
                    p.FinishTime = CurrentTime;
                    p.Finished = true;
                    p.RemainingDuration = 0;
                    p.LastExitTime = CurrentTime;
                    p.Status = ProcessStatus.Finished;
                    outcomingProcess = p;

                    if (p.WaitingTime == 0)
                    {
                        p.WaitingTime = CurrentTime - p.ArrivalTime;
                    }
                    else
                        p.WaitingTime += CurrentTime - p.LastEnterTime;

                    ProcessesEnded.Insert(0, p);

                }
                //Process must leave the CPU for I/O
                else if (p.CPUBound == false && p.LastEnterTime + p.BurstTime == CurrentTime)
                {
                    p.Status = ProcessStatus.InputOutput;
                    --p.RemainingDuration;
                    p.LastExitTime = CurrentTime;
                    if (p.WaitingTime == 0)
                    {
                        p.WaitingTime = CurrentTime - p.ArrivalTime;
                    }
                    else
                        p.WaitingTime += CurrentTime - p.LastEnterTime;
                    InsertProcessIntoQueue(p);
                    outcomingProcess = p;
                }
                //Last Process does not leave the CPU
                else
                {
                    --p.RemainingDuration;
                    p.Status = ProcessStatus.OnCpu;
                    ongoingProcess = p;
                }

                return new Tuple<Process, Process>(outcomingProcess, ongoingProcess);
            }
        }

        private void InsertProcessIntoQueue(Process process)
        {
            if (ProcessesQueue.Count == 0)
            {
                ProcessesQueue.Add(process);
            }
            else
            {
                int it = 0;
                bool positionFound = false;

                if (Algorithm == SchedulerAlgorithm.FCFS)
                {
                    while (!positionFound && it < ProcessesQueue.Count)
                    {
                        Process currentProcessInQueue = ProcessesQueue[it];
                        if (currentProcessInQueue.LastEnterTime == -1 &&
                            process.LastExitTime + process.IOTime < currentProcessInQueue.ArrivalTime)
                        {
                            positionFound = true;
                        }
                        else if (currentProcessInQueue.LastEnterTime != -1 &&
                                 process.LastEnterTime + process.IOTime < currentProcessInQueue.LastExitTime + currentProcessInQueue.IOTime)
                        {
                            positionFound = true;
                        }
                        ++it;
                    }
                }
                else if (Algorithm == SchedulerAlgorithm.SJF)
                {
                    //Insert process on the last position. Searches will be performed when we have to load another one on the CPU
                    it = ProcessesQueue.Count;
                }

                ProcessesQueue.Insert(it, process);
            }
        }

        #endregion
    }



    public enum SchedulerAlgorithm
    {
        FCFS = 1, //First Come First Serve
        SJF = 2, //Shortest Job First
        RR = 3 //Round Robin
    }

    public enum SchedulerStatus
    {
        On = 0,
        Off = 1
    }
}