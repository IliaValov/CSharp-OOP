using ExerciseSolid.Appenders.Contracts;
using ExerciseSolid.Core.Contracts;
using System;
using System.Collections.Generic;

namespace ExerciseSolid.Core
{
    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {


            Int32 n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();

                this.commandInterpreter.AddAppender(inputArgs);
            }

            string input = Console.ReadLine();
            while(input != "END")
            {
                string[] args = input.Split('|');

                this.commandInterpreter.AddMessage(args);

                input = Console.ReadLine();
            }

            this.commandInterpreter.PrintInfo();
        }
    }
}
