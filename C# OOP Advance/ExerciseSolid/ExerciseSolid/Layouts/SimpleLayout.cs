using ExerciseSolid.Layouts.Contracts;

namespace ExerciseSolid.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}
