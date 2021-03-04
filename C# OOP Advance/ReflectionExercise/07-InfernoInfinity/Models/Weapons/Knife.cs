using System;
using System.Collections.Generic;
using System.Text;

namespace _07_InfernoInfinity.Models.Weapons
{
    public class Knife : Weapon
    {
        private const int sockets = 2;
        private static int[] damage = new int[2] { 3, 4 };
        public Knife(string rarety)
            : base(sockets, damage , rarety)
        {
        }
    }
}
