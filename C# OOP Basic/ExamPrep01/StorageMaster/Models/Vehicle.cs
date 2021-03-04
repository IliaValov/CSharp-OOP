using StorageMaster.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Models
{
    public abstract class Vehicle : IVehicle
    {
        public int Capacity { get; set; }
        public List<Product> Trunk { get; set; }
        public bool IsFull { get; set; }
        public bool IsEmpty { get; set; }

        public Vehicle(int capacity)
        {
            Trunk = new List<Product>();
            this.Capacity = capacity;
        }

        public void LoadProduct(Product product)
        {
            if (Trunk.Count > Capacity)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            Trunk.Add(product);
        }
        public void UnloadProduct()
        {
            if (Trunk.Count < 1)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            Trunk.RemoveAt(Trunk.Count - 1);
        }
    }
}
