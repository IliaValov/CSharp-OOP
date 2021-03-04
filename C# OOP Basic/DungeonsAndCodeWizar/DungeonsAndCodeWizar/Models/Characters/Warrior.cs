using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Models.Bag;
using DungeonsAndCodeWizards.Models.Contracts;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Warrior : Character , IAttackable
    {
        private const double health = 100;
        private const double armor = 50;
        private const double abilityPoints = 40;
        private static Bag.Bag bag = new Satchel();

        public Warrior(string name, Faction faction) : 
            base(name, health, armor, abilityPoints, bag, faction)
        {
        }

        public void Attack(Character character)
        {
            if (this.IsAlive && character.IsAlive)
            {
                if (this.Name == character.Name)
                {
                    throw new InvalidOperationException("Cannot attack self!");
                }
                if (this.Faction == character.Faction)
                {
                    throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
                }

                character.Health -= this.AbilityPoints;
            }
        }
    }
}
