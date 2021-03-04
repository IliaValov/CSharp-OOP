using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Models.Characters;

namespace DungeonsAndCodeWizards.Models.Items
{
    public class PoisonPotion : Item
    {
        private const int weight = 5;

        public PoisonPotion() : base(weight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            character.Health -= 20;
        }
    }
}
