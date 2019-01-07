using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public class PlayGround
    {
        // Spielfeld - Mehrdimensionales Array
        public string[,] playground = new string[3,3];


        // Initialisierung des Spielfeldes
        private void InitPlayGround()
        {
            for(int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    playground[x, y] = "";
                }
            }
        }


        // Konstruktor
        public PlayGround()
        {
            InitPlayGround();
        }
    }
}
