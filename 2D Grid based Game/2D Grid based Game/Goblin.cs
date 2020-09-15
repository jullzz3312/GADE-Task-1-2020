using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Grid_based_Game
{
    class Goblin : Enemy
    {
        public Goblin(int xPos, int yPos, int HP, int MaxHP, int Damage, string Symbol)
           : base(xPos, yPos, HP, MaxHP, Damage, Symbol)
        {

        }
        public Goblin(int xPos, int yPos)
        {
            this.xPos = xPos;
            this.yPos = yPos;
        }

        public int MaxHP = 10;
        public int Damage = 1;

        public override int ReturnMove()
        {
           
        }
    }
}
