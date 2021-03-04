using _04_Lake.Models.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04_Lake.Models
{
    public class Frog : IFrog
    {
        private int[] stones;

        public Frog(params int[] args)
        {
            stones = new int[args.Length];
            Add(args);
            allStones();
        }

        private int[] EvenStones()
        {
            int counter = 0;

            for (int i = 0; i < stones.Length; i++)
            {
                if (stones[i] % 2 == 0)
                {
                    counter++;
                }
            }
            int[] evenStones = new int[counter];
            counter = 0;
            for (int i = stones.Length - 1; i >= 0; i--)
            {
                if (stones[i] % 2 == 0)
                {
                    evenStones[counter++] = stones[i];
                }
            }
            return evenStones;
        }

        private void allStones()
        {
            int[] newArr = new int[stones.Length];
            int[] evenStones = EvenStones();
            int[] oddStones = OddStones();


            for (int i = 0; i < oddStones.Length; i++)
            {
                newArr[i] = oddStones[i];
            }

            for (int i = oddStones.Length; i < newArr.Length; i++)
            {
                newArr[i] = evenStones[i - oddStones.Length];
            }



            this.stones = newArr;
        }

        private int[] OddStones()
        {
            int counter = 0;

            for (int i = 0; i < stones.Length; i++)
            {
                if (stones[i] % 2 != 0)
                {
                    counter++;
                }
            }
            int[] oddStones = new int[counter];
            counter = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (stones[i] % 2 != 0)
                {
                    oddStones[counter++] = stones[i];
                }
            }
            return oddStones;
        }

        private void Add(int[] args)
        {
            for (int i = 0; i < stones.Length; i++)
            {
                stones[i] = args[i];
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Length; i++)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
