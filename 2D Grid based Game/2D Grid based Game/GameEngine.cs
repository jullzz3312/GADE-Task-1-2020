using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Grid_based_Game
{
    class GameEngine
    {
        private int Map;

     
        public int mapX
        {
            get { return mapX; }
            set { mapX = value; }
        }
        public int mapY
        {
            get { return mapY; }
            set { mapY = value; }
        }
        public string HeroSymbol
        {
            get { return HeroSymbol; }
            set { HeroSymbol = value; }
        }
        public int xPos
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public int yPos
        {
            get { return yPos; }
            set { yPos = value; }
        }
        public bool MovePlayer()
        {
            if (xPos >= 0 && xPos < 20)
            {
                xPos = xPos;
            }
            if (yPos >= 0 && yPos < 20)
            {
                yPos = yPos;
            }
        }
    }
}
