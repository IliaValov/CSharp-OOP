using DungeonsAndCodeWizards.Models.Bag;
using System;
using System.Collections.Generic;
using System.Text;


namespace DungeonsAndCodeWizards.Models.Bag
{
    public class Backpack : Bag
    {
        private const int capacity = 100;

        public Backpack() : base(capacity)
        {
        }
    }
}
