using ExerciseSolid.Appenders.Contracts;
using ExerciseSolid.Layouts.Contracts;

namespace ExerciseSolid.Appenders
{
    using ExerciseSolid.Loggers.Contracts;
    using ExerciseSolid.Loggers.Enums;
    using System;
    using System.IO;
    public class FileAppender : Appender, IAppender
    {
        private const string path = "../../../log.txt";
        private readonly ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile file) : base(layout)
        {
            this.logFile = file;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.MessagesCount++;
                string content = String.Format(Layout.Format, dateTime, reportLevel, message) + "\n";
                this.logFile.Write(content);
                File.AppendAllText(path, content);
            }

        }


        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel.ToString()}, Messages appended: {this.MessagesCount}, File size: {this.logFile.Size}\n";
        }
    }
}
