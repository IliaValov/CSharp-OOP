using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storages
{
    public class DistributionCenter : Storage
    {
        private const int capacity = 2;
        private const int garageSlots = 5;

        private static Vehicle[] vehicles = new Vehicle[]
        {
            new Van(),
            new Van(),
            new Van()
        };

        public DistributionCenter(string name)
            : base(name, capacity, garageSlots, vehicles)
        {
        }
    }
}
