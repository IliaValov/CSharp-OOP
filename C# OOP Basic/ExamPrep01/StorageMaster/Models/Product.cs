using StorageMaster.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Models
{
    public abstract class Product : IProduct
    {
        public double Price { get;}
        public double Weight { get; set; }

        public Product(double price)
        {
            if (price < 0)
            {
                throw new InvalidOperationException("Price cannot be negative!");
            }
            this.Price = price;          
        }
    }
}
