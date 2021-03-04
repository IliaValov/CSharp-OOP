using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Крайният резултат го записвам тук
            List<string> sortedPolinom = new List<string>();
            //Беше тест
            string[] tempArray = new string[6];
            //Тук взимам информацията от конзолата
            string polinom = Console.ReadLine();
            string[] input = polinom.Split(new string[] { " - ", " + " }, StringSplitOptions.None);

            //Проверявам ако дължината на полинома е по-малка от 3 значи е непълен
            if (input.Length < 3)
            {

                //добавям първата част от полинома
                string firstChar = input[0].Split('/')[0];
                string secondChar = input[0].Split('/')[1];
                sortedPolinom.Add(firstChar);
                sortedPolinom.Add(secondChar);

                //проверявам коя част липсва тук се отказвам защото много ми е завъртяна задачата ако съм успял да ти дам идея супер

                sortedPolinom.Add("0");
                sortedPolinom.Add("1");

                //Преизползвам променливите от по-горе
                firstChar = input[1].Split('/')[0];
                secondChar = input[1].Split('/')[1];
                //тук добавам последната част
                sortedPolinom.Add(firstChar);
                sortedPolinom.Add(secondChar);

            }
            else
            {
                //Ако всичко е пълно започвам да попълвам листа по условието
                for (int i = 0; i < input.Length; i++)
                {
                    string firstChar = input[i].Split('/')[0];
                    string secondChar = input[i].Split('/')[1];
                    sortedPolinom.Add(firstChar);
                    sortedPolinom.Add(secondChar);

                }
            }

            Console.WriteLine($"{sortedPolinom[0]}/{sortedPolinom[1]}:{sortedPolinom[2]}/{sortedPolinom[3]}:{sortedPolinom[4]}/{sortedPolinom[5]}");
        }
    }
}
