using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPU_Scheduling_Simulator.Helpers;

namespace CPU_Scheduling_Simulator
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
            Output.AddTimeLabelsOnChart(splitContainerRight.Panel2);
            Output.AddProcessesLabelsOnChart(splitContainerLeft.Panel2);
            Output.AssignProcessesColors();
            Output.GenerateChartLabels();
            Output.DrawProcesses(splitContainerRight.Panel2);
        }

    }
}
