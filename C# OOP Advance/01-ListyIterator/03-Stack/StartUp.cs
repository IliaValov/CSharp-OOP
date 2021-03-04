using _03_Stack.Models;
using System;
using System.Linq;

namespace _03_Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<string> stack = new CustomStack<string>();
            string[] command = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                try
                {
                    switch (command[0])
                    {
                        case "Pop":
                            stack.Pop();
                            break;
                        case "Push":
                            stack.Push(command.Skip(1).ToArray());
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



            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
