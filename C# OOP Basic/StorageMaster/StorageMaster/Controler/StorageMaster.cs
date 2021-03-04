using StorageMaster.Factories;
using StorageMaster.Models.Products;
using StorageMaster.Models.Storages;
using StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Controler
{
    public class StorageMaster
    {
        private Dictionary<string, Stack<Product>> products = new Dictionary<string, Stack<Product>>();
        private Dictionary<string, Storage> storages = new Dictionary<string, Storage>();
        private Vehicle currentVehicle;

        public string AddProduct(string type, double price)
        {
            Product product = ProductFactory.FactoryProduct(type, price);

            if (!products.ContainsKey(type))
            {
                products.Add(type, new Stack<Product>());
            }

            products[type].Push(product);

            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = StorageFactory.FactoryStorage(type, name);

            if (!storages.ContainsKey(name))
            {
                storages.Add(name, storage);
            }


            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = storages[storageName];

            this.currentVehicle = storage.GetVehicle(garageSlot);

            return $"Selected {currentVehicle.GetType().Name}";


        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int LoadedProductsCount = 0;

            foreach (var item in productNames)
            {
                if (this.currentVehicle.IsFull)
                {
                    break;
                }

                if (!products.ContainsKey(item) ||
                    products[item].Count == 0)
                {
                    throw new InvalidOperationException($"{item} is out of stock!");
                }

                Product product = products[item].Pop();
                this.currentVehicle.LoadProduct(product);
                LoadedProductsCount++;
            }
            return $"Loaded {LoadedProductsCount}/{productNames.Count()} products into {this.currentVehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (!storages.ContainsKey(sourceName))
            {
                throw new InvalidOperationException("Invalid source storage!");
            }
            if (!storages.ContainsKey(destinationName))
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            Storage sourceStorage = storages[sourceName];

            Vehicle vehicle = sourceStorage.GetVehicle(sourceGarageSlot);

            Storage destinationStorage = storages[destinationName];

            int destinationGarageSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);

            return $"Sent {vehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = storages[storageName];

            int vehicleCount = storage.GetVehicle(garageSlot).Trunk.Count;

            int unloadedProductsCount = storage.UnloadVehicle(garageSlot);

            Vehicle vehicle = storage.GetVehicle(garageSlot);

            return $"Unloaded {unloadedProductsCount}/{vehicleCount} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            StringBuilder sbProducts = new StringBuilder();
            Dictionary<string, int> productCount = new Dictionary<string, int>();
            Storage storage = storages[storageName];
            string[] garage = new string[storage.GarageSlots];

            foreach (var item in storage.Products)
            {
                string getName = item.GetType().Name;
                if (!productCount.ContainsKey(getName))
                {
                    productCount.Add(getName, 1);
                }
                else
                {
                    productCount[getName]++;
                }
            }
            double sumWeight = storage.Products.Sum(p => p.Weight);

            sbProducts.Append($"Stock ({sumWeight}/{storage.Capacity}): [");
            int counter = 0;
            foreach (var item in productCount.OrderByDescending(k => k.Value).ThenBy(k => k.Key))
            {
                if (counter == 0)
                {
                    sbProducts.Append($"{item.Key} ({item.Value})");
                }
                else
                {
                    sbProducts.Append($", {item.Key} ({item.Value})");
                }
            }
            sbProducts.AppendLine("]");


            //Garage
            counter = 0;
            foreach (var item in storage.Garage)
            {
                if (item == null)
                {
                    garage[counter++] = "empty";
                }
                else
                {
                    garage[counter++] = item.GetType().Name;
                }
            }

            sbProducts.Append("Garage: [");
            sbProducts.Append(String.Join('|', garage));
            sbProducts.Append("]");


            return sbProducts.ToString();
        }

        public string GetSummary()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in storages.OrderByDescending(k => k.Value.Products.Sum(p => p.Price)))
            {
                double worth = item.Value.Products.Sum(p => p.Price);
                sb.AppendLine($"{item.Key}:");
                sb.AppendLine($"Storage worth: ${worth:F2}");
            }

            return sb.ToString();
        }

    }
}
