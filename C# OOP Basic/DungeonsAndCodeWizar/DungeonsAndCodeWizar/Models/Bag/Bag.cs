using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Bag
{
    public abstract class Bag
    {
        private int capacity;
        private List<Item> bag;
        

        public Bag(int capacity)
        {
            bag = new List<Item>();
            this.Capacity = capacity;
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public IReadOnlyCollection<Item> Items
        {
            get { return bag; }
        }

        public int Load => bag.Sum(p => p.Weight);

        public virtual void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }
            bag.Add(item);
        }

        public virtual Item GetItem(string name)
        {
            int index = IsContains(bag, name);

            if (bag.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }
            if (index < 0)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }


            Item item = bag[index];
            bag.RemoveAt(index);
            return item;
        }

        private int IsContains(List<Item> bag, string name)
        {
            int counter = 0;
            foreach (var item in bag)
            {
                if (item.GetType().Name == name)
                {
                    return counter;
                }
                counter++;
            }
            return -1;
        }
    }
}

