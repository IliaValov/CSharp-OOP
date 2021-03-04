using System;
using System.Collections.Generic;
using System.Linq;

namespace Hit_Listt
{
    class Program
    {
        static void Main(string[] args)
        {
            var targets = new Dictionary<string, Dictionary<string, string>>();
            int neededIndex = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end transmissions")
            {
                for (int j = 1; j < input.Length; j++)
                {
                    string[] currentPersonInfo = input[j].Split(new char[] { ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                    if (!targets.ContainsKey(input[0]))
                    {
                        targets.Add(input[0], new Dictionary<string, string>());
                        for (int i = 0; i < currentPersonInfo.Length; i += 2)
                        {
                            if (!targets[input[0]].ContainsKey(currentPersonInfo[i]))
                            {
                                targets[input[0]].Add(currentPersonInfo[i], currentPersonInfo[i + 1]);
                            }
                            else
                            {
                                targets[input[0]][currentPersonInfo[i]] = currentPersonInfo[i + 1];
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < currentPersonInfo.Length; i += 2)
                        {
                            if (!targets[input[0]].ContainsKey(currentPersonInfo[i]))
                            {
                                targets[input[0]].Add(currentPersonInfo[i], currentPersonInfo[i + 1]);
                            }
                            else
                            {
                                targets[input[0]][currentPersonInfo[i]] = currentPersonInfo[i + 1];
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            }
            string[] murderHim = Console.ReadLine().Split().ToArray();
            int indexResult = 0;

            Console.WriteLine($"Info on {murderHim[1]}:");
            foreach (var item in targets[murderHim[1]].OrderBy(x => x.Key))
            {
                indexResult += item.Key.Length + item.Value.Length;
                Console.WriteLine($"---{item.Key}: {item.Value}");
            }
            if (indexResult >= neededIndex)
            {
                Console.WriteLine($"Info index: {indexResult}");
                Console.WriteLine($"Proceed");
            }
            else
            {
                Console.WriteLine($"Info index: {indexResult}");
                Console.WriteLine($"Need {neededIndex - indexResult} more info.");
            }
        }
    }
}
