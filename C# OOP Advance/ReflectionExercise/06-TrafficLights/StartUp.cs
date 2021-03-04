using _06_TrafficLights.Models;
using System;

namespace _06_TrafficLights
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Lights lights = new Lights();
            string[] colors = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                colors = lights.ChangeColor(colors);
                Console.WriteLine(String.Join(" ", colors));
            }
        }
    }
}
