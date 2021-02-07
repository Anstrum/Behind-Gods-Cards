using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BehindGodsCards.MyGame.Structures
{
    public class Barracks : Batiments
    {
        public StructureStats StructStats;
        public int Hp;
        public int Armor;
        public int MaxUnits;
        public int Lvl;


        public Barracks()
        {
            StructStats = new StructureStats();
            Lvl = 1;
            Hp = StructStats.barracks.Lvl1.Health;
            Armor = StructStats.barracks.Lvl1.Armor;
        }

        public void LevelUp()
        {
            Lvl = Lvl + 1;
            if (Lvl == 2)
            {
                Hp = StructStats.barracks.Lvl2.Health;
                Armor = StructStats.barracks.Lvl2.Armor;
            }
            if (Lvl == 3)
            {
                Hp = StructStats.barracks.Lvl3.Health;
                Armor = StructStats.barracks.Lvl3.Armor;
            }
        }
    }
}
