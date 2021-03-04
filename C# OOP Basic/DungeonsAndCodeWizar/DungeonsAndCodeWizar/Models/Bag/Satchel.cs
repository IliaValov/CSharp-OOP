using DungeonsAndCodeWizards.Models.Bag;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Bag
{
    class Satchel : Bag
    {
        private const int capacity = 20;

        public Satchel() : base(capacity)
        {
        }
    }
}
