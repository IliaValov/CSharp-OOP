﻿using DungeonsAndCodeWizards.Models.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Items
{
   public abstract class Item
    {
        private int weight;

        public Item(int weight)
        {
            this.Weight = weight;
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public abstract void AffectCharacter(Character character);

    }
}
