using System;
using System.Collections.Generic;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            Stack<long> fibonaci = new Stack<long>();

            fibonaci.Push(0);
            fibonaci.Push(1);


            for (long i = 1; i < input; i++)
            {
                long result = fibonaci.Pop();
                result += fibonaci.Peek();
                long lastDigit = fibonaci.Pop();
                fibonaci.Push(result);
                fibonaci.Push(lastDigit);

            }
            Console.WriteLine(fibonaci.Pop() + fibonaci.Pop());
        }
    }
}
