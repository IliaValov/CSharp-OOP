

namespace ExerciseSolid.Appenders
{
    using ExerciseSolid.Appenders.Contracts;
    using ExerciseSolid.Layouts.Contracts;
    using ExerciseSolid.Loggers.Enums;
    using System;

    public class ConsoleAppender : Appender, IAppender
    {

        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.MessagesCount++;
                Console.WriteLine(string.Format(Layout.Format, dateTime, reportLevel, message));
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel.ToString()}, Messages appended: {this.MessagesCount}\n";
        }
    }
}
