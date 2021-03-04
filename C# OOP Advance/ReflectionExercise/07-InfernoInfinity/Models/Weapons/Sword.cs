using _07_InfernoInfinity.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07_InfernoInfinity.Models
{
    public class Sword : Weapon
    {
        private const int sockets = 3;
        private static int[] damage = new int[2] { 4, 6 };
        public Sword(string rarety)
            : base(sockets, damage, rarety)
        {
        }
    }
}
