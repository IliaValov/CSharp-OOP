using ExerciseSolid.Appenders.Contracts;
using ExerciseSolid.Appenders.Factory;
using ExerciseSolid.Appenders.Factory.Contracts;
using ExerciseSolid.Core.Contracts;
using ExerciseSolid.Layouts.Factory;
using ExerciseSolid.Layouts.Factory.Contracts;
using ExerciseSolid.Loggers.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ExerciseSolid.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory;

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }

        public void AddAppender(string[] args)
        {
            string appenderType = args[0];
            string layoutType = args[1];
            ReportLevel reportLevel = ReportLevel.INFO;

            if (args.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2]);
      
            }

            IAppender appender = this.appenderFactory.CreateAppender(appenderType, layoutFactory.CreateLayout(layoutType));
            appender.ReportLevel = reportLevel;
            this.appenders.Add(appender);
        }   

        public void AddMessage(string[] args)
        {
            ReportLevel reportLevel = Enum.Parse<ReportLevel>(args[0]);
            string dateTime = args[1];
            string message = args[2];

            foreach (var appender in appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Logger info\n");

            foreach (var append in appenders)
            {

                Console.WriteLine(append);
            }
        }
    }
}
