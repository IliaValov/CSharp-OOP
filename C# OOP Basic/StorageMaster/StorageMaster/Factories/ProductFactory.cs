using StorageMaster.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Factories
{
    public class ProductFactory
    {
        public static Product FactoryProduct(string type, double price)
        {
            switch (type)
            {
                case "Gpu":
                    return new Gpu(price);
                case "HardDrive":
                    return new HardDrive(price);
                case "Ram":
                    return new Ram(price);
                case "SolidStateDrive":
                    return new SolidStateDrive(price);
                default:
                    throw new InvalidOperationException("Invalid product type!");
            }
        }
    }
}
