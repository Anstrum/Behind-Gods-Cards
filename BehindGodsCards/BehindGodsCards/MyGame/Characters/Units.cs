using System;
using System.Collections.Generic;
using System.Text;

namespace BehindGodsCards.MyGame.Characters
{
    public class Units
    {
        public int Health;
        public int Armor;
        public int Damage;
        public int Cost;
        public int Lvl;

        public Units(int UnitLvl)
        {
            Lvl = UnitLvl;
        }

        public void TakeDamage(int Value)
        {
            Health -= Value - Armor;
        }
    }
}
