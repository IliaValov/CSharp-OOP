using System;
using ExerciseSolid.Appenders.Contracts;
using ExerciseSolid.Loggers.Contracts;
using ExerciseSolid.Loggers.Enums;

namespace ExerciseSolid.Loggers
{
    public class Logger : ILogger
    {
        private IAppender consoleAppender;
        private IAppender fileAppender;

        public Logger(IAppender append)
        {
            this.consoleAppender = append;
        }

        public Logger(IAppender append, IAppender fileAppender) : this(append)
        {
            this.fileAppender = fileAppender;
        }

        public void Error(string dateTime, string message)
        {
            this.AppendMessage(dateTime, ReportLevel.ERROR, message);
        }

        internal void Warning(string dateTime, string message)
        {
            this.AppendMessage(dateTime, ReportLevel.WARNING, message);
        }

        public void Critical(string dateTime, string message)
        {
            this.AppendMessage(dateTime, ReportLevel.CRITICAL, message);
        }

        public void Fatal(string dateTime, string message)
        {
            this.AppendMessage(dateTime, ReportLevel.FATAL, message);
        }

        public void Info(string dateTime, string message)
        {
            this.AppendMessage(dateTime, ReportLevel.INFO, message);
        }


        private void AppendMessage(string dateTime, ReportLevel reportLevel, string message)
        {
            consoleAppender?.Append(dateTime, reportLevel, message);
            fileAppender?.Append(dateTime, reportLevel, message);
        }
    }

}
