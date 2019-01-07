using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public class Player
    {
        // Spielernamen
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Punkte
        private int points;

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        // Aktueller Spieler
        private bool currentPlayer;

        public bool CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        // PlayerSign
        private string playerSign;

        public string PlayerSign    
        {
            get { return playerSign; }
            set { playerSign = value; }
        }

        // First turn
        private bool firstTurn;

        public bool FirstTurn
        {
            get { return firstTurn; }
            set { firstTurn = value; }
        }
    }
}
