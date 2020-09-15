using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Grid_based_Game
{
    class Hero : Character
    {
        public Hero(int yPos, int xPos, int HP, int MaxHP, int Damage, string Symbol)
          : base(xPos, yPos, HP, MaxHP, Damage, Symbol)
        {
           /*public Hero(int xPos, int yPos, int HP, int MaxHP, int Damage, string Symbol)
            {
                this.xPos = xPos;
                this.yPos = yPos;
                this.HP = HP;
                this.MaxHP = HP;
                this.Damage = Damage;
                this.Symbol = Symbol;
            } */
            Damage = 2;
        }

        public override int ReturnMove()
        {
            
        }
        public override string ToString()
        {
            string output;

            output = "Player Stats:" + "\n";
            output += "HP/MaxHP" + HP/MaxHP + "\n";
            output += "Damage" + Damage + "\n";
            output += "X Position" + xPos + "\n";
            output += "Y Position" + yPos + "\n";

            return output;
        }
    }
}
