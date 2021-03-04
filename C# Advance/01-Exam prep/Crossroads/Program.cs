using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int counter = 0;
            while (input != "END")
            {
                int greenLightSeconds = greenLight;
                if (input != "green")
                {
                    queue.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }
                while (queue.Count != 0 && greenLightSeconds > 0)
                {
                    if (greenLightSeconds - queue.Peek().Length >= 0)
                    {
                        greenLightSeconds -= queue.Dequeue().Length;
                        counter++;
                    }
                    else if (greenLightSeconds - queue.Peek().Length < 0)
                    {
                        int length = queue.Peek().Length - greenLightSeconds;

                        if (freeWindow - length >= 0)
                        {
                            queue.Dequeue();
                            counter++;
                            greenLightSeconds = 0;
                        }
                        else
                        {
                            string str = queue.Dequeue();
                            char[] result = str.ToCharArray();
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{str} was hit at {result[freeWindow + greenLightSeconds]}.");
                            greenLightSeconds = 0;
                            return;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
