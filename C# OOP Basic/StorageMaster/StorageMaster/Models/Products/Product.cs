using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Models.Products
{
    public abstract class Product
    {
        private double price;
        private double weight;

        public Product(double price, double weight)
        {
            this.Weight = weight;
            this.Price = price;
        }

        public double Price
        {
            get { return price; }
            private set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }
                price = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            private set { weight = value; }
        }


    }
}
