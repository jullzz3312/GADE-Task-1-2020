using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Grid_based_Game
{
    abstract class Character : Tile
    {
        public Character(int xPos, int yPos)
            : base(xPos, yPos)
        {

        }

        protected int HP;
        protected int MaxHP;
        protected int Damage;
        protected string Symbol;
        protected string[,] CharactersVision = new string[2,2];

        #region Constructors

        

       

        public Character(int xPos, int yPos, int hP, int maxHP, int damage, string symbol) : this(xPos, yPos)
        {
            this.hP = hP;
            MaxHP = maxHP;
            this.damage = damage;
            Symbol = symbol;
        }
        #endregion



        #region Accessors
        public int hP
        {
            get { return HP; }
            set { HP = value; }
        }
        public int maxhp
        {
            get { return MaxHP; }
            set { MaxHP = value; }
        }
        public int damage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        #endregion

        public enum Movement
        {
            NoMovement,
            Up,
            Down,
            Left,
            Right
        }
        public virtual void Attack()
        {

        }

        public bool isDead()
        {
            return true;
        }

        public virtual bool CheckRange()
        {
            return true;
        }
        
        private int DistanceTo()
        {
            return 1;
        }
        
        public void Move()
        {

        }

        public abstract int ReturnMove();


        public abstract override string ToString();
  
    }
}
