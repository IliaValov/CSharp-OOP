using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercisesGenerics.Models
{
    public class Box<T>
        where T : IComparable<T>
    {
        private T message;
        private List<T>items;

        public Box()
        {
            items = new List<T>();
        }

        public T Message
        {
            get { return message; }
            set
            {
                message = value;
                items.Add(value);
            }
        }

        public int GetGreatherThan(T inputItem)
        {
            int count = 0;

            foreach (var item in items)
            {
                if (item.CompareTo(inputItem) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public void Swap(int[] swapIndexes, List<Box<T>> arr)
        {
            Box<T> currentIndex = arr[swapIndexes[0]];
            arr[swapIndexes[0]] = arr[swapIndexes[1]];
            arr[swapIndexes[1]] = currentIndex;
        }

        public override string ToString()
        {
            return $"{message.GetType().FullName}: {message}";
        }
    }
}
