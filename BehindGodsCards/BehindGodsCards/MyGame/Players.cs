using System;
using System.Collections.Generic;
using System.Text;
using BehindGodsCards.MyGame.Structures;
using BehindGodsCards.MyGame.Characters;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BehindGodsCards.MyGame
{
    public class Players
    {
        
        public List<Units> Characters = new List<Units>();
        public int Money;
        public int MaxMoney;
        public int MaxUnit;
        public int Farmer;
        public bool IsBot;
        public string PlayerName;
        public HQ Base;

        public Players()
        {
            Base = new HQ();
            Money = 100;
            MaxMoney = 10000;
            MaxUnit = 10;
            Farmer = 0;
        }

        public bool AddMoney(int ValueToAdd)
        {
            Money += ValueToAdd;
            if(Money > MaxMoney)
            {
                Money = MaxMoney;
                return false;
            }
            return true;
        }

        public bool UseMoney(int ValueToRemove)
        {   
            if (Money >= ValueToRemove)
            {
                Money -= ValueToRemove;
                return true;
            }
            return false;
        }
    }
}
