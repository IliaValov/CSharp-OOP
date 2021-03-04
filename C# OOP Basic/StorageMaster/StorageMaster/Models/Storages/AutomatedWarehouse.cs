using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private const int capacity = 1;
        private const int garageSlots = 2;

        private static Vehicle[] vehicles = new Vehicle[]
        {
            new Truck()
        };

        public AutomatedWarehouse(string name)
            : base(name, capacity, garageSlots, vehicles)
        {
        }
    }
}
