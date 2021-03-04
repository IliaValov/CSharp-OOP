using IteratorsAndComparatorsExercise.Models;
using System;
using System.Linq;
using System.Text;

namespace IteratorsAndComparatorsExercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> list = new ListyIterator<string>();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                try
                {
                    switch (command[0])
                    {
                        case "Create":
                            list.Create(command.Skip(1).ToArray());
                            break;
                        case "HasNext":
                            Console.WriteLine(list.HasNext().ToString());
                            break;
                        case "Move":
                            Console.WriteLine(list.Move().ToString());
                            break;
                        case "Print":
                            list.Print();
                            break;
                        case "PrintAll":
                            Console.WriteLine(string.Join(" ", list));
                            break;
                        default:
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                command = Console.ReadLine().Split();

            }

        }
    }
}
