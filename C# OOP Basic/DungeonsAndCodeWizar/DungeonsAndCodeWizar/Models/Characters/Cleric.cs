using DungeonsAndCodeWizards.Models.Bag;
using DungeonsAndCodeWizards.Models.Contracts;
using System;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Characters
{
    class Cleric : Character, IHealable
    {
      private const double health = 50;
        private const double armor = 25;
        private const double abilityPoints = 40;
        private static Bag.Bag bag = new Backpack();

        public Cleric(string name , Faction faction) 
            : base(name, health, armor, abilityPoints, bag, faction)
        {
        }

        public void Heal(Character character)
        {
            if (this.IsAlive && character.IsAlive)
            {
                if (this.Faction != character.Faction)
                {
                    throw new ArgumentException($"Cannot heal enemy character!");
                }

                character.Health += this.AbilityPoints;
            }
        }

    }
}
