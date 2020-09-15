using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Grid_based_Game
{
    abstract class Enemy : Character
    {

        public Enemy(int xPos, int yPos, int HP, int MaxHP, int Damage, string Symbol)
            : base( xPos, yPos, HP, MaxHP, Damage, Symbol)
        {

        }
        protected int randomObject;

        public Enemy(int xPos, int yPos, int Damage, int HP, string Symbol, int MaxHP) : this(xPos, yPos)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.Damage = Damage;
            this.HP = HP;
            this.MaxHP = MaxHP;
            this.Symbol = Symbol;
        }

        public Enemy(int xPos, int yPos) : base(xPos, yPos)
        {
        }

        public override string ToString()
        {
            string output;
            output = "Enemy" + Symbol;
            output += "at" + (xPos,yPos);
            output += "Damage" + damage;

            return output;
        }
    }
}
