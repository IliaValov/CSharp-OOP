using ExercisesGenerics.Models;
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace ExercisesGenerics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //List<Box<string>> boxes = new List<Box<string>>();
            Box<double> box = new Box<double>(); ;


            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Message = input;
            }



            double element = double.Parse(Console.ReadLine());

            Console.WriteLine(box.GetGreatherThan(element));
        }
    }
}
