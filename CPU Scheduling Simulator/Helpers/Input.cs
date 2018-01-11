using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling_Simulator.Helpers
{
    public class Input
    {
        public static string CheckInputErrors(string duration, string arrivalTime, string priority, string burstTime, string ioTime)
        {
            string errorResponse = String.Empty;
            string stringBullet = "\u2022";

            //Check if input fields are null or empty 
            if (String.IsNullOrEmpty(duration))
            {
                errorResponse += stringBullet + "Process Duration must be specified.\n";
            }
            if (String.IsNullOrEmpty(arrivalTime))
            {
                errorResponse += stringBullet + "Arrival Time must be specified.\n";
            }
            if (String.IsNullOrEmpty(priority))
            {
                errorResponse += stringBullet + "Even if priority is not necessary it must be specified as a number.\n";
            }
            if (String.IsNullOrEmpty(burstTime))
            {
                errorResponse += stringBullet + "Burst Time must be specified.\n";
            }
            if (String.IsNullOrEmpty(ioTime))
            {
                errorResponse += stringBullet + "I/O Time must be specified.\n";
            }

            //Check if input fields contains only digits
            if (!String.IsNullOrEmpty(duration) && !CheckIfStringIsNumber(duration))
            {
                errorResponse += stringBullet + "Process Duration must be a number.\n";
            }
            if (!String.IsNullOrEmpty(arrivalTime) && !CheckIfStringIsNumber(arrivalTime))
            {
                errorResponse += stringBullet + "Arrival Time must be a number.\n";
            }
            if (!String.IsNullOrEmpty(priority) && !CheckIfStringIsNumber(priority))
            {
                errorResponse += stringBullet + "Process Priority must be a number.\n";
            }
            if (!String.IsNullOrEmpty(burstTime) && !CheckIfStringIsNumber(burstTime))
            {
                errorResponse += stringBullet + "Burst Time must be a number.\n";
            }
            if (!String.IsNullOrEmpty(ioTime) && !CheckIfStringIsNumber(ioTime))
            {
                errorResponse += stringBullet + "I/O must be a number.\n";
            }

            //Check if Duration is positive
            if (!String.IsNullOrEmpty(duration) && CheckIfStringIsNumber(duration) && Int32.Parse(duration) <= 0)
            {
                errorResponse += stringBullet + "Process Duration must be a positive number.\n";
            }

            //Check if we have I/O Time with positive Burst Time
            if (!String.IsNullOrEmpty(ioTime) && CheckIfStringIsNumber(ioTime) &&
                Int32.Parse(ioTime) > 0 &&
                !String.IsNullOrEmpty(burstTime) && !CheckIfStringIsNumber(burstTime)
                && Int32.Parse(burstTime) <= 0)
            {
                errorResponse += stringBullet + "If I/O time is positive we must have a positive burst time.\n";
            }

            return errorResponse;
        }

        public static bool CheckIfStringIsNumber(string str)
        {
            return str.All(char.IsDigit);
        }

        public static void AddProcessToTable(DataGridView grid, int id, string duration, string arrivalTime, string priority, string burstTime, string ioTime)
        {
            string[] newRow = new  string[]
            {
               id.ToString(), duration, arrivalTime, priority, burstTime, ioTime
            };
            grid.Rows.Add(newRow);
        }
    }
}
