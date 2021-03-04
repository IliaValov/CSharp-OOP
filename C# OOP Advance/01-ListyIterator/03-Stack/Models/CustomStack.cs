using _03_Stack.Models.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03_Stack.Models
{
    public class CustomStack<T> : ICustomStack<T>
    {
        private T[] array;

        public CustomStack()
        {
            array = new T[0];
        }

        public int Count { get; private set; }

        public T Pop()
        {
            if (Count < 1)
            {
                throw new InvalidOperationException("No elements");
            }
          T element = array[Count - 1];
                array[Count - 1] = default(T);
                Count--;

                return element;
        }

        public void Push(params T[] args)
        {
            if (array.Length == 0)
            {
                array = new T[args.Length];
            }
            if (Count == array.Length && array.Length > 0)
            {
                Rezise();
            }

            foreach (var item in args)
            {
                array[Count++] = item;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void Rezise()
        {
            T[] newArray = new T[array.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
    }
}
