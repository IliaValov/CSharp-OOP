using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Crypto_Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            var blockChain = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());

            string sequnce = "";
            string result = "";

            for (int i = 0; i < n; i++)
            {
                sequnce += Console.ReadLine();
            }

            string pattern = @"{[^\]]*?([0-9]+)[^\[]*?}|\[[^\}]*?([0-9]+)[^\{]*?\]";

            Regex patt = new Regex(pattern);
            var matches = patt.Matches(sequnce);


            foreach (Match match in matches)
            {
                if (match.Groups[1].Value.Length % 3 != 0)
                {
                    continue;
                }else if (match.Groups[2].Value.Length % 3 != 0)
                {
                    continue;
                }

                int lastPosition = 0;
                if (match.Groups[1].Value.Length > 0)
                {
                    for (int i = 0; i <= match.Groups[1].Value.Length; i++)
                    {
                        string num = "";
                        if (i % 3 == 0 && i > 0)
                        {
                            for (int j = lastPosition; j < i; j++)
                            {
                                num += match.Groups[1].Value[j];
                            }
                            if (!blockChain.ContainsKey(match.ToString()))
                            {
                                blockChain.Add(match.ToString(), new List<int>());
                                blockChain[match.ToString()].Add(int.Parse(num));
                            }
                            else
                            {
                                blockChain[match.ToString()].Add(int.Parse(num));
                            }
                            lastPosition = i;
                        }

                    }
                }
                else
                {
                    for (int i = 0; i <= match.Groups[2].Value.Length; i++)
                    {
                        string num = "";
                        if (i % 3 == 0 && i > 0)
                        {
                            for (int j = lastPosition; j < i; j++)
                            {
                                num += match.Groups[2].Value[j];
                            }
                            if (!blockChain.ContainsKey(match.ToString()))
                            {
                                blockChain.Add(match.ToString(), new List<int>());
                                blockChain[match.ToString()].Add(int.Parse(num));
                            }
                            else
                            {
                                blockChain[match.ToString()].Add(int.Parse(num));
                            }
                            lastPosition = i;
                        }

                    }
                }

            }

            foreach (var item in blockChain)
            {
                int length = item.Key.Length;
                foreach (var number in item.Value)
                {
                    int currentNum = number;
                    char symbol = (char)(currentNum - length);
                    result += symbol.ToString();
                }
            }
            Console.WriteLine(result);
        }
    }
}
