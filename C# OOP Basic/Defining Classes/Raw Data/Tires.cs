using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
    class Tires
    {
        public decimal TirePresure { get; set; }
        public int TireAge { get; set; }

        public Tires(decimal tirePresure, int tireAge)
        {
            this.TirePresure = tirePresure;
            this.TireAge = tireAge;
        }
    }
}
