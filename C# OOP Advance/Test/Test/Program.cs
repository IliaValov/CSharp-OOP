using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.WriteLine();

            int spaces = n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < n - spaces ; j++)
                {
                    Console.Write("*");
                }

                Console.Write("|");

                for (int j = 0; j < n - spaces; j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                spaces--;
            }
            //fdfdfd

            //    fd   *
            //        **
            //       ***

            //    df
            //    df
            //    fd
            //    df
            //    fd

            //    d
        }
    }
}
