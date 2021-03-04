using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<int> plants = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> survivedPlants = new List<int>();
            List<int> markedPlants = new List<int>();

            int count = 0;
            while (true)
            {
                int diedPlants = 0;
                for (int i = 0; i < plants.Count - 1; i++)
                {
                    int firstPlant = plants[i];
                    int secondPlant = plants[i + 1];

                    if (firstPlant < secondPlant)
                    {
                        markedPlants.Add(i + 1);
                        diedPlants++;
                    }
                   
                }
                if (markedPlants.Count > 0)
                {
                    for (int i = markedPlants.Count - 1; i >= 0; i--)
                    {
                        plants.RemoveAt(markedPlants[i]);
                    }
                    markedPlants.Clear();
                }
                if (diedPlants == 0)
                {
                    break;
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
