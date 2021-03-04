using System;
using System.Collections.Generic;
using System.Text;

namespace _06_TrafficLights.Models
{
    public class Lights
    {
        private string red = "Green";
        private string green = "Yellow";
        private string yellow = "Red";

        public string[] ChangeColor(string[] colors)
        {
            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i] == "Red")
                {
                    colors[i] = red;
                }
                else if (colors[i] == "Green")
                {
                    colors[i] = green;
                }
                else if (colors[i] == "Yellow")
                {
                    colors[i] = yellow;
                }
            }

            return colors;
        }
    }
}
