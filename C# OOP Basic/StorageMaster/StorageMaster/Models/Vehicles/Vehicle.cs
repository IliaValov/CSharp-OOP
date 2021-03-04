using StorageMaster.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Models.Vehicles
{
    public abstract class Vehicle
    {
        private int capacity;
        private List<Product> trunk;


        public Vehicle(int capacity)
        {
            this.Capacity = capacity;
            trunk = new List<Product>();
            //TODO
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();

        public bool IsFull => this.Trunk.Sum(p => p.Weight) >= this.Capacity;

        public bool IsEmpty => this.Trunk.Count == 0;

        public void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            trunk.Add(product);
        }

        public Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            int lastIndex = trunk.Count - 1;

            Product removeProduct = trunk[lastIndex];

            trunk.RemoveAt(lastIndex);

            return removeProduct;
        }
    }
}
