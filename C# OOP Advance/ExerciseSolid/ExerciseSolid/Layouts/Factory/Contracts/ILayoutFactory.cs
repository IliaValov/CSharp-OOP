using ExerciseSolid.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSolid.Layouts.Factory.Contracts
{
   public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
