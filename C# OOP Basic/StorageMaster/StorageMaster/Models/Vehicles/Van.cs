﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Models.Vehicles
{
    public class Van : Vehicle
    {
        private const int capacity = 2;

        public Van() : base(capacity)
        {
        }
    }
}
