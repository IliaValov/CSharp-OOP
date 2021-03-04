using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tricket_Trouble
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> seats = new List<string>();
            List<string> result = new List<string>();
            string destination = Console.ReadLine();

            string tickets = Console.ReadLine();

            string pattern = @"{[^}]*\[([A-Z]{3} [A-Z]{2})\].*?\[([A-Z]{1}[1-9]{1,2})\][^{]*}|\[[^\]]*{([A-Z]{3} [A-Z]{2})}.*?{([A-Z]{1}[0-9]{1,2})}[^\[]*\]";

            Regex patt = new Regex(pattern);
            var matches = patt.Matches(tickets);
            foreach (Match match in matches)
            {
                if (match.Groups[1].Value == destination || match.Groups[3].Value == destination)
                {
                    if (match.Groups[1].Value == destination)
                    {
                        seats.Add(match.Groups[2].Value);
                    }
                    else
                    {
                        seats.Add(match.Groups[4].Value);
                    }
                }
            }
            if (seats.Count > 2)
            {
                for (int i = 0; i < seats.Count; i++)
                {

                    for (int j = i + 1; j < seats.Count; j++)
                    {
                        if (seats[i][1] == seats[j][1] && seats[i][2] == seats[j][2])
                        {
                            result.Add(seats[i]);
                            result.Add(seats[j]);
                            break;
                        }
                    }
                }

                Console.WriteLine($"You are traveling to {destination} on seats {result[0]} and {result[1]}.");
            }
            else
            {
                Console.WriteLine($"You are traveling to {destination} on seats {seats[0]} and {seats[1]}.");
                return;
            }


        }
    }
}
