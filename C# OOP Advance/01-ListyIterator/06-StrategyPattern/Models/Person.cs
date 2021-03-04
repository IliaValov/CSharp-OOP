using _06_StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06_StrategyPattern.Models
{
    public class Person : IPerson<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(Person other)
        {
            if (this.Name.Length > other.Name.Length)
            {
                return 1;
            }
            else if (this.Name.Length < other.Name.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
