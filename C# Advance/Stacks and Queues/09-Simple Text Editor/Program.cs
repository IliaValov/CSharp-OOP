using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _09_Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> previousCommands = new Stack<string>();
            string text = string.Empty;
            int operationCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < operationCount; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string operation = input[0];

                switch (operation)
                {
                    case "1":
                        previousCommands.Push(text);
                        text += input[1];
                        break;

                    case "2":
                        previousCommands.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(input[1]));
                        break;

                    case "3":
                        Console.WriteLine(text[int.Parse(input[1]) - 1]);
                        break;
                    case "4":
                        text = previousCommands.Pop();
                        break;
                }
            }
        }
    }
}
