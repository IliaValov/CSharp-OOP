using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a jaggedArray with lists
            List<List<int>> tables = new List<List<int>>(20);


            //fill in the jaggedArray
            for (int i = 0; i < 20; i++)
            {
                tables.Add(new List<int>());


                if (i >= 0 && i <= 10)
                {
                    tables[i].Add(2);
                }
                else if (i >= 11 && i <= 15)
                {
                    tables[i].Add(4);
                }
                else if (i >= 16 && i <= 20)
                {
                    tables[i].Add(6);
                }

                tables[i].Add(0);
            }


            //Doing while the client want to end the program with command END
            while (true)
            {
                Console.WriteLine("Enter number of people");
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                //I'm using try catch because if there is no space i will throw exception with message
                try
                {
                    int peopleForAccomondation = int.Parse(input);
                    //I'm using this bool for checking if the client is accomondated or not with true false and if statement
                    bool isAccommodated = false;

                    
                    for (int i = 0; i < tables.Count; i++)
                    {
                        //tables[i] is the second list tables[i][0] is the space for the table tables[i][1] is a bool with 0 or 1 - 0 false 1 true
                        if (tables[i][0] >= peopleForAccomondation && tables[i][1] != 1)
                        {
                            tables[i][1] = 1;
                            isAccommodated = true;
                            Console.WriteLine("The clients are accommondated");
                            break;
                        }
                    }
                    //Check if the client is accomondated
                    if (isAccommodated == true)
                    {
                        continue;
                    }
                    //Check if he is not
                    if (isAccommodated == false)
                    {
                        throw new ArgumentException("There is no space for accommondation");
                    }

                }
                catch (Exception ex)
                {
                    //Printing on the console exception with the properly message

                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
