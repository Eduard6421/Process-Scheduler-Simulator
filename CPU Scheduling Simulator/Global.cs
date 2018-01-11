using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPU_Scheduling_Simulator.Helpers;
using CPU_Scheduling_Simulator.Models;

namespace CPU_Scheduling_Simulator
{
    //Global class is used to encapsulate global variables (ex.: Scheduler instance)
    static class Global
    {
        static Global()
        {
            Scheduler = new Scheduler();
        }

        public static Scheduler Scheduler { get; set; }
    }
}
