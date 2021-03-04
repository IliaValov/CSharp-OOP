using System;
using System.Collections.Generic;
using System.Linq;

namespace Sneaking
{
    class Program
    {
        public static int row = 0;
        public static int col = 0;
        public static bool isDeath = false;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());


            char[][] room = new char[rows][];

            for (int i = 0; i < room.Length; i++)
            {
                room[i] = Console.ReadLine().ToCharArray();

                if (room[i].Contains('S'))
                {
                    row = i;
                    col = Array.IndexOf(room[i], 'S');
                    if (room[i].Contains('b') && Array.IndexOf(room[i], 'b') < col)
                    {
                        Console.WriteLine($"Sam died at {row}, {col}");
                        room[row][col] = 'X';
                        Print(room);
                        return;
                    }else if (room[i].Contains('d') && Array.IndexOf(room[i], 'd') > col)
                    {
                        Console.WriteLine($"Sam died at {row}, {col}");
                        room[row][col] = 'X';
                        Print(room);
                        return;
                    }
                }
            }

            char[] commands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {
                MoveEnemies(room);
                if (room[row].Contains('b') && Array.IndexOf(room[row], 'b') < col)
                {
                    Console.WriteLine($"Sam died at {row}, {col}");
                    room[row][col] = 'X';
                    Print(room);
                    return;
                }
                else if (room[row].Contains('d') && Array.IndexOf(room[row], 'd') > col)
                {
                    Console.WriteLine($"Sam died at {row}, {col}");
                    room[row][col] = 'X';
                    Print(room);
                    return;
                }

                MoveSam(room, commands[i]);
                if (room[row].Contains('N'))
                {
                    Console.WriteLine("Nikoladze killed!");
                    room[row][Array.IndexOf(room[row], 'N')] = 'X';
                    Print(room);
                    return;
                }

            }
        }

        private static void MoveSam(char[][] room, char command)
        {
            switch (command)
            {

                case 'U':
                    room[row][col] = '.';
                    row = row - 1;
                    room[row][col] = 'S';
                    break;

                case 'D':
                    room[row][col] = '.';
                    row = row + 1;
                    room[row][col] = 'S';
                    break;

                case 'R':
                    room[row][col] = '.';
                    col = col + 1;
                    room[row][col] = 'S';
                    break;

                case 'L':
                    room[row][col] = '.';
                    col = col - 1;
                    room[row][col] = 'S';
                    break;
            }
        }

        private static void Print(char[][] room)
        {
            for (int i = 0; i < room.Length; i++)
            {

                for (int j = 0; j < room[i].Length; j++)
                {
                    Console.Write(room[i][j]);
                }
                Console.WriteLine();
            }
        }

        private static void MoveEnemies(char[][] room)
        {
            for (int i = 0; i < room.Length; i++)
            {
                int indexD = Array.IndexOf(room[i], 'd');
                int indexB = Array.IndexOf(room[i], 'b');

                if (indexD != -1)
                {
                    if (indexD == 0)
                    {
                        room[i][indexD] = 'b';
                    }
                    else
                    {
                        room[i][indexD] = '.';
                        indexD--;
                        room[i][indexD] = 'd';
                    }



                }
                else if (indexB != -1)
                {
                    if (indexB == room[i].Length - 1)
                    {
                        room[i][indexB] = 'd';
                    }
                    else
                    {
                        room[i][indexB] = '.';
                        indexB++;
                        room[i][indexB] = 'b';
                    }


                }
            }
        }
    }

}
