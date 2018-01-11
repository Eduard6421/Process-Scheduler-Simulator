using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CPU_Scheduling_Simulator.Models
{
    public class Process
    {
        public int Id { get; set; }

        public int ArrivalTime { get; set; }

        public int Duration { get; set; }

        public int RemainingDuration { get; set; }

        public int ResponseTime { get; set; }

        public int FinishTime { get; set; }

        public int WaitingTime { get; set; }

        public bool Finished { get; set; }

        public int Priority { get; set; }

        public int BurstTime { get; set; }

        public int IOTime { get; set; }

        public int LastEnterTime {get; set; }

        public int LastExitTime { get; set; }

        public ProcessStatus Status { get; set; }

        public bool CPUBound { get; set; }

        public Process() { }

        public Process(int id, int duration, int arrivalTime, int priority, int burstTime, int ioTime)
        {
            Id = id;
            Duration = duration;
            ArrivalTime = arrivalTime;
            Priority = priority;
            BurstTime = burstTime;
            IOTime = ioTime;
            Status = ProcessStatus.NotStarted;
            RemainingDuration = Duration;
            Finished = false;
            LastEnterTime = -1;
            LastExitTime = -1;
            if (ioTime == 0)
            {
                CPUBound = true;
            }
            else
            {
                CPUBound = false;
            }
        }

    }

    public enum ProcessStatus
    {
        NotStarted = -1,
        Waiting = 0,
        OnCpu = 1,
        InputOutput = 2,
        Finished = 3
    }
}
