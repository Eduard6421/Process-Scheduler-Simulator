using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPU_Scheduling_Simulator.Models;
using Color = System.Drawing.Color;

namespace CPU_Scheduling_Simulator.Helpers
{
    public class Output
    {
        private static IList<Tuple<int, int, int>> ProcessesLabels { get; set; }
        private static IList<System.Drawing.Color> ProcessesColors { get; set; }

        public static void AddTimeLabelsOnChart(SplitterPanel splitterPanel)
        {
            int itStop = Global.Scheduler.KeyTimes.Count - 1;
            for (int it = 0; it < itStop; it++)
            {
                var newTimeLabel = new Label();
                newTimeLabel.AutoSize = false;
                newTimeLabel.Size = new Size(40, 42);
                newTimeLabel.Location = new Point(it*40, 0);
                newTimeLabel.Text = it.ToString();
                newTimeLabel.TextAlign = ContentAlignment.MiddleLeft;
                newTimeLabel.BorderStyle = BorderStyle.FixedSingle;
                splitterPanel.Controls.Add(newTimeLabel);
            }
        }

        public static void AddProcessesLabelsOnChart(SplitterPanel splitterPanel)
        {
            int itStop = Global.Scheduler.ProcessesList.Count;
            for (int it = 0; it < itStop; it++)
            {
                var newProcessLabel = new Label();
                newProcessLabel.AutoSize = false;
                newProcessLabel.Size = new Size(47,30);
                newProcessLabel.Location = new Point(0, it*30);
                newProcessLabel.Text = "P" + it.ToString();
                newProcessLabel.TextAlign = ContentAlignment.MiddleLeft;
                newProcessLabel.BorderStyle = BorderStyle.FixedSingle;
                splitterPanel.Controls.Add(newProcessLabel);
            }
        }

        public static void DrawProcesses(SplitterPanel splitterPanel)
        {
            for (int it = 0; it < ProcessesLabels.Count; it++)
            {
                Tuple<int,int,int> label = ProcessesLabels[it];

                Label newBar = new Label();
                newBar.AutoSize = false;
                newBar.BackColor = ProcessesColors[label.Item1 - 1];
                newBar.Size = new Size((label.Item3-label.Item2) * 40, 30);
                newBar.Location = new Point(label.Item2 * 40, 47 + (label.Item1-1) * 30);
                splitterPanel.Controls.Add(newBar);
            }
        }

        public static void AssignProcessesColors()
        {
            ColorPicker colorPicker = new ColorPicker();
            ProcessesColors = new List<System.Drawing.Color>();

            for (int it = 0; it < Global.Scheduler.ProcessesList.Count; it++)
            {
                  ProcessesColors.Add(colorPicker.PickRandomColor());
            }
        }

        public static void GenerateChartLabels()
        {
            int processId = -1;
            int processLastEnterTime = -1;
            int it = 0;
            IList<KeyTime> keyTimes = Global.Scheduler.KeyTimes.ToList();
            ProcessesLabels = new List<Tuple<int, int, int>>();

            while (it < keyTimes.Count)
            {
                Process ongoingProcess = keyTimes[it].OngoingProcess;
                Process outgoingProcess = keyTimes[it].OutgoingProcess;

                if (outgoingProcess != null)
                {
                    ProcessesLabels.Add(new Tuple<int, int, int>(processId, processLastEnterTime, it));
                    processId = -1;
                    processLastEnterTime = -1;
                }

                if (processId == -1 && ongoingProcess != null)
                {
                    processId = ongoingProcess.Id;
                    processLastEnterTime = it;
                }

                ++it;
            }
        }
    }
}
