using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> leftLocks = new Queue<int>();
            Stack<int> barrel = new Stack<int>();
            int bulletCost = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int locksPrice = int.Parse(Console.ReadLine());

            int bulletCounter = 0;

            bool isEmpty = false;

            foreach (var item in bullets)
            {
                barrel.Push(item);
            }
            foreach (var item in locks)
            {
                leftLocks.Enqueue(item);
            }

            while(true)
            {
                int bullet = barrel.Pop();
                int currentLock = leftLocks.Peek();
                bulletCounter++;

                if (bullet <= currentLock)
                {
                    leftLocks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (bulletCounter % gunBarrelSize == 0 && barrel.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }

                if (barrel.Count == 0 && leftLocks.Count > 0)
                {
                    isEmpty = true;
                }
                if (barrel.Count == 0 || leftLocks.Count == 0)
                {
                    break;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {leftLocks.Count}");
            }
            else
            {
                Console.WriteLine($"{barrel.Count} bullets left. Earned ${locksPrice - (bulletCounter * bulletCost)}");
            }


        }
    }
}
