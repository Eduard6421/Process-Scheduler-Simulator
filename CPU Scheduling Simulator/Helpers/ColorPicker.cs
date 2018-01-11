using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPU_Scheduling_Simulator.Models;
using Color = System.Drawing.Color;

namespace CPU_Scheduling_Simulator.Helpers
{
    public class ColorPicker
    {
        public Dictionary<ColorsEnum, System.Drawing.Color> Colors { get; set; }

        public ColorPicker()
        {
            Colors = new Dictionary<ColorsEnum, Color>();

            Colors.Add(ColorsEnum.OrangeRed, System.Drawing.Color.OrangeRed);
            Colors.Add(ColorsEnum.CadetBlue, System.Drawing.Color.CadetBlue);
            Colors.Add(ColorsEnum.Gold, System.Drawing.Color.Gold);
            Colors.Add(ColorsEnum.DarkCyan, System.Drawing.Color.DarkCyan);
            Colors.Add(ColorsEnum.Magenta, System.Drawing.Color.Magenta);
            Colors.Add(ColorsEnum.Brown, System.Drawing.Color.Brown);
            Colors.Add(ColorsEnum.CornflowerBlue, System.Drawing.Color.CornflowerBlue);
            Colors.Add(ColorsEnum.DarkGreen, System.Drawing.Color.DarkGreen);
            Colors.Add(ColorsEnum.DarkRed, System.Drawing.Color.DarkRed);
            Colors.Add(ColorsEnum.DarkSlateGray, System.Drawing.Color.DarkSlateGray);
        }

        public System.Drawing.Color PickRandomColor()
        {
            Array values = Enum.GetValues(typeof(ColorsEnum));
            ColorsEnum randomColorKey = (ColorsEnum) values.GetValue(StaticRandom.Instance.Next(values.Length));

            return Colors[randomColorKey];
        }
    }
}
