using ExerciseSolid.Appenders;
using ExerciseSolid.Appenders.Contracts;
using ExerciseSolid.Core;
using ExerciseSolid.Core.Contracts;
using ExerciseSolid.Layouts;
using ExerciseSolid.Layouts.Contracts;
using ExerciseSolid.Loggers;
using ExerciseSolid.Loggers.Contracts;
using ExerciseSolid.Loggers.Enums;

namespace ExerciseSolid
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            IEngine engine = new Engine(commandInterpreter);
            engine.Run();


        }
    }
}
