using System;

namespace CustomList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ISoftuniList<string> softuniList = new SoftuniList<string>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                //void Add(T element)
                //T Remove(int index)
                //bool Contains(T element)
                //void Swap(int index1, int index2)
                //int CountGreaterThan(T element)
                //T Max()
                //T Min()



                string command = input[0];

                switch (command)
                {
                    case "Add":
                        softuniList.Add(input[1]);
                        break;
                    case "Remove":
                        softuniList.Remove(int.Parse(input[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(softuniList.Contains(input[1]));
                        break;
                    case "Swap":
                        softuniList.Swap(int.Parse(input[1]), int.Parse(input[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(softuniList.CountGreaterThan(input[1]));
                        break;
                    case "Max":
                        Console.WriteLine(softuniList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(softuniList.Min());
                        break;
                    case "Sort":
                        softuniList.Sort();
                        break;
                    case "Print":
                        foreach (var item in softuniList)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    default:
                        break;

                }


                input = Console.ReadLine().Split();
            }

        }
    }
}
