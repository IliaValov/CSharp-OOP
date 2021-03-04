using _07_InfernoInfinity.Models.Weapons.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07_InfernoInfinity.Models.Weapons
{
    public class Weapon : IWeapon
    {
        public int[] Damage { get; protected set; }
        public int[] Sockets { get; set; }

        public int Strength { get; private set; } = 0;
        public int Agility { get; private set; } = 0;
        public int Vitality { get; private set; } = 0;

        public Weapon(int sockets, int[] damage, string rarety)
        {
            this.Sockets = new int[sockets];
            this.Damage = damage;
            BonusDmg(rarety);
        }

        private void BonusDmg(string rarety)
        {
            switch (rarety)
            {
                case "Common":
                    this.Damage[0] *= 1;
                    this.Damage[1] *= 1;
                    break;
                case "Uncommon":
                    this.Damage[0] *= 2;
                    this.Damage[1] *= 2;
                    break;
                case "Rare":
                    this.Damage[0] *= 3;
                    this.Damage[1] *= 3;
                    break;
                case "Epic":
                    this.Damage[0] *= 5;
                    this.Damage[1] *= 5;
                    break;
            }
        }
    }
}
