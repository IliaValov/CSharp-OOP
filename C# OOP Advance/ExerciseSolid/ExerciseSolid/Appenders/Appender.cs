using ExerciseSolid.Appenders.Contracts;
using ExerciseSolid.Layouts.Contracts;
using ExerciseSolid.Loggers.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSolid.Appenders
{
    public abstract class Appender : IAppender
    {
        private readonly ILayout layout;

        protected Appender(ILayout layout)
        {
            this.layout = layout;
        }

        protected ILayout Layout => layout;

        public ReportLevel ReportLevel { get; set; }

        public int MessagesCount { get; protected set; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);

    }
}
