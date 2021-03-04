using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomList
{
    public class SoftuniList<T> : ISoftuniList<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        private const int InitialCapacity = 4;

        private T[] array;

        public SoftuniList()
        {
            array = new T[InitialCapacity];
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Add(T element)
        {
            if (this.array.Length == this.Count)
            {
                this.Resize();
            }

            array[this.Count++] = element;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public int CountGreaterThan(T element)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            int count = 0;

            for (int i = 0; i < Count; i++)
            {
                if (this.array[i].CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            T maxValue = this.array[0];

            for (int i = 1; i < this.Count; i++)
            {
                if (this.array[i].CompareTo(maxValue) > 0)
                {
                    maxValue = this.array[i];
                }
            }
            return maxValue;
        }

        public T Min()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            T minValue = this.array[0];

            for (int i = 1; i < this.Count; i++)
            {
                if (this.array[i].CompareTo(minValue) < 0)
                {
                    minValue = this.array[i];
                }
            }
            return minValue;
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new InvalidOperationException();
            }
            T element = this.array[index];
            this.array[index] = default(T);
            this.Count--;

            for (int i = index; i < this.Count; i++)
            {
                this.array[i] = this.array[i + 1];
            }

            this.array[Count] = default(T);

            return element;
        }

        public void Sort()
        {
            for (int i = 0; i < this.Count; i++)
            {

                for (int j = 0; j < this.Count; j++)
                {

                    if (this.array[i].CompareTo(this.array[j]) < 0)
                    {
                        T swapElement = this.array[i];
                        this.array[i] = this.array[j];
                        this.array[j] = swapElement;

                    }
                }
            }

        }
        public void Swap(int index1, int index2)
        {
            T swapElement = this.array[index1];
            this.array[index1] = this.array[index2];
            this.array[index2] = swapElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void Resize()
        {
            T[] newArr = new T[this.array.Length * 2];

            for (int i = 0; i < this.array.Length; i++)
            {
                newArr[i] = this.array[i];
            }

            this.array = newArr;
        }

        public override string ToString()
        {
            return string.Join("\n", this.array.Take(this.Count)).TrimEnd();
        }


    }
}
