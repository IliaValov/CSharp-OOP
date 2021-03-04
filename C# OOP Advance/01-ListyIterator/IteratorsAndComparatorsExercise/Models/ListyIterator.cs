using IteratorsAndComparatorsExercise.Models.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparatorsExercise.Models
{
    public class ListyIterator<T> : IListyIterator<T>, IEnumerable<T>
    {
        private T[] array;

        private int currentPosition = 0;

        public ListyIterator()
        {

        }

        public void Create(params T[] args)
        {
            if (args.Length == 0)
            {
                array = new T[0];
            }
            else
            {
                array = new T[args.Length];

                for (int i = 0; i < args.Length; i++)
                {
                    array[i] = args[i];
                }
            }
        }

        public bool HasNext()
        {
            if (array.Length == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            if (currentPosition < array.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Move()
        {
            if (array.Length == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            if (currentPosition < array.Length - 1)
            {
                currentPosition++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (array.Length == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            string result = array[currentPosition].ToString();
            Console.WriteLine(result);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
