using System;
using System.Collections.Generic;
using System.Text;

namespace _07_InfernoInfinity.Models.Gems
{
    public class Gem
    {
        public int Strength { get; private set; }
        public int Agility { get; private set; }
        public int Vitality { get; private set; }

        public Gem(int strength, int agility, int vitality)
        {
            this.Strength = strength;
            this.Agility = agility;
            this.Vitality = vitality;
        }
    }
}
