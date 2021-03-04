using System;
using System.Collections.Generic;
using System.Linq;

namespace Movie_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> playList = new Dictionary<string, int>();
            string typeFilm = Console.ReadLine();
            string duration = Console.ReadLine();
            int playListDuration = 0;

            string[] filmInfo = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (filmInfo[0] != "POPCORN!")
            {
                if (typeFilm == filmInfo[1])
                {
                    string filmName = filmInfo[0];
                    if (!playList.ContainsKey(filmName))
                    {
                        string[] time = filmInfo[2].Split(":", StringSplitOptions.RemoveEmptyEntries);
                        int seconds = int.Parse(time[0]) * 3600;
                        seconds += int.Parse(time[1]) * 60;
                        seconds += int.Parse(time[2]);
                        playListDuration += seconds;

                        playList.Add(filmName, seconds);
                    }
                    else
                    {
                        string[] time = filmInfo[2].Split(":", StringSplitOptions.RemoveEmptyEntries);
                        int seconds = int.Parse(time[0]) * 3600;
                        seconds += int.Parse(time[1]) * 60;
                        seconds += int.Parse(time[2]);
                        playListDuration += seconds;
                        playList[filmName] = seconds;
                    }

                }



                filmInfo = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            }
            if (duration == "long")
            {
                foreach (var item in playList.OrderByDescending(x => x.Value))
                {
                    string input = Console.ReadLine();
                    Console.WriteLine(item.Key);
                    int hours = item.Value / 3600;
                    int minutes = item.Value / 60;
                    int seconds = item.Value - minutes * 60 + hours * 3600;

                    if (input == "Yes")
                    {

                        Console.WriteLine($"We're watching {item.Key} - {hours:D2}:{minutes:D2}:{seconds:D2}:");
                        hours = playListDuration / 3600;
                        minutes = playListDuration / 60;
                        seconds = playListDuration - minutes * 60 + hours * 3600;
                        Console.WriteLine($"Total Playlist Duration: {hours:D2}:{minutes:D2}:{seconds:D2}");
                        break;
                    }
                }
            }
            else
            {
                foreach (var item in playList.OrderBy(x => x.Value))
                {
                    string input = Console.ReadLine();
                    Console.WriteLine(item.Key);
                    int hours = item.Value / 3600;
                    int minutes = item.Value / 60;
                    int seconds = item.Value - minutes * 60 + hours * 3600;

                    if (input == "Yes")
                    {

                        Console.WriteLine($"We're watching {item.Key} - {hours:D2}:{minutes:D2}:{seconds:D2}:");                       
                        minutes = playListDuration / 60;
                        hours = minutes / 60;
                        seconds = playListDuration - minutes * 60 + hours * 3600;
                        Console.WriteLine($"Total Playlist Duration: {hours:D2}:{minutes:D2}:{seconds:D2}");
                        break;
                    }
                }
            }



        }
    }
}
