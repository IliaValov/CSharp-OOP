using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Contracts
{
    interface IProduct
    {
        double Price { get;}
        double Weight { get; set; }
    }
}
