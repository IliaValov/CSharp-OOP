using _06_StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_StrategyPattern
{
    class StartUp
    {
        public static List<Person> list = new List<Person>();
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string name = input.Split()[0];
                int age = int.Parse(input.Split()[1]);
                Person person = new Person(name, age);

                list.Add(person);
            }

            SortByName();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }
            SortByAge();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }

        }

        public static void SortByName()
        {

            for (int i = 0; i < list.Count; i++)
            {

                for (int j = 0; j < list.Count; j++)
                {

                    if (list[i].Name.ToCharArray()[0].ToString().CompareTo(list[j].Name.ToCharArray()[0].ToString()) < 0)
                    {
                        Person swapElement = list[i];
                        list[i] = list[j];
                        list[j] = swapElement;

                    }
                    else if (list[i].Name.Length.CompareTo(list[j].Name.Length) < 0)
                    {
                        Person swapElement = list[i];
                        list[i] = list[j];
                        list[j] = swapElement;
                    }
                }
            }

        }

        public static void SortByAge()
        {
            for (int i = 0; i < list.Count; i++)
            {

                for (int j = 0; j < list.Count; j++)
                {

                    if (list[i].Age.CompareTo(list[j].Age) < 0)
                    {
                        Person swapElement = list[i];
                        list[i] = list[j];
                        list[j] = swapElement;

                    }
                   
                }
            }
        }
    }
}
