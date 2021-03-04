using _04_Lake.Models;
using System;
using System.Linq;

namespace _04_Lake
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Frog frog = new Frog(stones);

            Console.WriteLine(string.Join(", ", frog));
        }
    }
}
