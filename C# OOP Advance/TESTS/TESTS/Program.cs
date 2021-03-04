using System;

namespace TESTS
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeSpan = new TimeSpan(0,60,59);

            int minutes = timeSpan.Hours * 60 + timeSpan.Minutes;
            int seconds = timeSpan.Seconds;

            Console.WriteLine($"{minutes:D2}:{seconds:D2}");
        }
    }
}
