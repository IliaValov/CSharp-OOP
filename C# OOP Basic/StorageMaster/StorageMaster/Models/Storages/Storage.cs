using StorageMaster.Models.Products;
using StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Models.Storages
{
    public abstract class Storage
    {
        private string name;
        private List<Product> products;
        private int capacity;
        private int garageSlots;
        private Vehicle[] garage;

        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            garage = new Vehicle[garageSlots];
            AddVehicles(vehicles);
            products = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int GarageSlots
        {
            get { return garageSlots; }
            set { garageSlots = value; }
        }

        public IReadOnlyCollection<Vehicle> Garage
        {
            get => garage;
        }

        public IReadOnlyCollection<Product> Products
        {
            get { return products.AsReadOnly(); }
        }

        public bool IsFull => products.Sum(p => p.Weight) >= Capacity;

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= GarageSlots) throw new InvalidOperationException("Invalid garage slot!");
            if (garage[garageSlot] == null) throw new InvalidOperationException("No vehicle in this garage slot!");

            return garage[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = GetVehicle(garageSlot);

            int foundGarageSlotIndex = deliveryLocation.AddVehicleToGarage(vehicle);

            deliveryLocation.garage[foundGarageSlotIndex] = vehicle;

            garage[garageSlot] = null;

            return foundGarageSlotIndex;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (IsFull) throw new InvalidOperationException("Storage is full!");

            Vehicle vehicle = GetVehicle(garageSlot);

            int counter = 0;
            while (!this.IsFull && !vehicle.IsEmpty)
            {
                Product product = vehicle.Unload();
                this.products.Add(product);
                counter++;
            }
            return counter;
        }

        private int AddVehicleToGarage(Vehicle vehicle)
        {
            int freeGarageSlot = Array.IndexOf(this.garage.ToArray(), null);

            if (freeGarageSlot == -1)
            {
                throw new InvalidOperationException("No room in garage!");
            }

            return freeGarageSlot;
        }

        private void AddVehicles(IEnumerable<Vehicle> vehicles)
        {
            int index = 0;
            foreach (var item in vehicles)
            {
                garage[index++] = item;
            }
        }
    }
}
