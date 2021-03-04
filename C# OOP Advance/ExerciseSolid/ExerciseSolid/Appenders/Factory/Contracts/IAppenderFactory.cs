using ExerciseSolid.Appenders.Contracts;
using ExerciseSolid.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSolid.Appenders.Factory.Contracts
{
    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
