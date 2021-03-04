using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storages
{
    public class Warehouse : Storage
    {
        private const int capacity = 10;
        private const int garageSlots = 10;

        private static Vehicle[] vehicles = new Vehicle[]
        {
            new Semi(),
            new Semi(),
            new Semi()
        };

        public Warehouse(string name) 
            : base(name, capacity, garageSlots, vehicles)
        {
        }
    }
}
