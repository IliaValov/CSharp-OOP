using StorageMaster.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Contracts
{
    interface IVehicle
    {
        int Capacity { get; set; }
        List<Product> Trunk { get; set; }
        bool IsFull { get; set; }
        bool IsEmpty { get; set; }
    }
}
