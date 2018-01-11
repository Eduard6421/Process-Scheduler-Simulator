using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduling_Simulator.Models
{
    public class KeyTime
    {
        public int Timestamp { get; set; }

        public Process Process { get; set; }

        public Process OutgoingProcess { get; set; }

        public Process OngoingProcess { get; set; }

        public bool CpuOnLoad { get; set; }

        public KeyTime()
        {
            Process = null;
            OutgoingProcess = null;
            OngoingProcess = null;
            CpuOnLoad = false;
        }
    }

}
