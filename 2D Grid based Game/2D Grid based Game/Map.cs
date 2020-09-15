using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Grid_based_Game
{
    class Map
    {
        public string[,] map = new string[20, 20];
        public string HeroSymbol = "H";
        public string[,] enemy = new string[0, 1];
        public int mapX;
        public int mapY;
        Random rnd = new Random();

        #region Constructors
        public Map(int mapX, int mapY, string HeroSymbol)
        {
            this.mapX = mapX;
            this.mapY = mapY;
            this.HeroSymbol = HeroSymbol;
        }
        #endregion

        public void Create()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    Random rnd = new Random();
                    int xPos = rnd.Next(0, 20);
                    int yPos = rnd.Next(0, 20);
                }
            }
        }
    }
}
