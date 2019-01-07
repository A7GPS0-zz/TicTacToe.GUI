using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLib;

namespace TicTacToe.GUI
{
    public partial class PlayerSettings : Form
    {
        public PlayerSettings()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();
            Player player2 = new Player();

            player1.Name = txtPlayer1.Text;
            player2.Name = txtPlayer2.Text;

            player1.PlayerSign = "X";
            player2.PlayerSign = "O";

            if (chkBoxSpieler1Start.Checked)
            {
                player1.FirstTurn = true;
                player2.FirstTurn = false;
            }
            else
            {
                player1.FirstTurn = false;
                player2.FirstTurn = true;
            }

            new FormTicTacToe(player1, player2).Show();
            this.Hide();
        }
    }
}
