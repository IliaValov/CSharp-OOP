using System;
using System.Collections.Generic;
using System.Text;

namespace _07_InfernoInfinity.Models.Weapons.Contracts
{
    public interface IWeapon
    {
        int[] Damage { get; }
        int[] Sockets { get; set; }

        int Strength { get; }
        int Agility { get; }
        int Vitality { get; }
    }
}
