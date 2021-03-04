using System;
using System.Collections.Generic;
using System.Text;

namespace _07_InfernoInfinity.Models.Weapons
{
    public class Axe : Weapon
    {
        private const int sockets = 4;
        private static int[] damage = new int[2] { 5, 10 };
        public Axe(string rarety)
            : base(sockets, damage , rarety)
        {
        }
    }
}
