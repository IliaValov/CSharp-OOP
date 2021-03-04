using System;

namespace CustomTuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Sofka Tripova Stolipinovo
            //Az 2
            //23 21.23212321
            string[] fullName = Console.ReadLine().Split();
            SpecialTuple<string, string, string> firstTuple = new SpecialTuple<string, string, string>(fullName[0] + " " + fullName[1], fullName[2], fullName[3]);
            string[] input2 = Console.ReadLine().Split();
            SpecialTuple<string, int, string> secondTuple = new SpecialTuple<string, int, string>(input2[0], int.Parse(input2[1]),input2[2]);
            string[] input3 = Console.ReadLine().Split();
            SpecialTuple<string, double , string> thirdTuple = new SpecialTuple<string, double , string>(input3[0], double.Parse(input3[1]), input3[2]);

            Console.WriteLine(firstTuple);
            Console.WriteLine($"{secondTuple.Item1} -> {secondTuple.Item2} -> {secondTuple.isDrunk()}");
            Console.Write(thirdTuple);
        }
    }
}
