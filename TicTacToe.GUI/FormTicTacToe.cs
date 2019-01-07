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
    public partial class FormTicTacToe : Form
    {
        PlayGround ground;
        Player player1;
        Player player2;
        int counter = 0;

        public FormTicTacToe(Player player1, Player player2)
        {
            InitializeComponent();
            ground = new PlayGround();
            this.player1 = player1;
            this.player2 = player2;

            if(player1.FirstTurn)
                tsslAktuellerSpieler.Text = player1.Name;
            else
                tsslAktuellerSpieler.Text = player2.Name;
        }

        /*
         * BUTTON 1 
        */
        private void btn_Field1_Click(object sender, EventArgs e)
        {
            if (ground.playground[0, 0] != "")
                return;

            if (player1.CurrentPlayer || (player1.FirstTurn && counter == 0))
            {
                if (player1.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 0, 0, player1);
                btn_Field1.Text = player1.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player1))
                    Winner(player1);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player2.Name;
                player2.CurrentPlayer = true;
                player1.CurrentPlayer = false;
            }
            else if (player2.CurrentPlayer || (player2.FirstTurn && counter == 0))
            {
                if (player2.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 0, 0, player2);
                btn_Field1.Text = player2.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player2))
                    Winner(player2);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player1.Name;
                player1.CurrentPlayer = true;
                player2.CurrentPlayer = false;
            }
        }


        /*
         *  BUTTON 2
        */
        private void btn_Field2_Click(object sender, EventArgs e)
        {
            if (ground.playground[0, 1] != "")
                return;

            if (player1.CurrentPlayer || (player1.FirstTurn && counter == 0))
            {
                if (player1.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 0, 1, player1);
                btn_Field2.Text = player1.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player1))
                    Winner(player1);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player2.Name;
                player2.CurrentPlayer = true;
                player1.CurrentPlayer = false;
            }
            else if (player2.CurrentPlayer || (player2.FirstTurn && counter == 0))
            {
                if (player2.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 0, 1, player2);
                btn_Field2.Text = player2.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player2))
                    Winner(player2);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player1.Name;
                player1.CurrentPlayer = true;
                player2.CurrentPlayer = false;
            }
        }


        /*
         * BUTTON 3
        */ 
        private void btn_Field3_Click(object sender, EventArgs e)
        {
            if (ground.playground[0, 2] != "")
                return;

            if (player1.CurrentPlayer || (player1.FirstTurn && counter == 0))
            {
                if (player1.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 0, 2, player1);
                btn_Field3.Text = player1.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player1))
                    Winner(player1);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player2.Name;
                player2.CurrentPlayer = true;
                player1.CurrentPlayer = false;
            }
            else if (player2.CurrentPlayer || (player2.FirstTurn && counter == 0))
            {
                if (player2.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 0, 2, player2);
                btn_Field3.Text = player2.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player2))
                    Winner(player2);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player1.Name;
                player1.CurrentPlayer = true;
                player2.CurrentPlayer = false;
            }
        }


        /*
         * BUTTON 4
        */
        private void btn_Field4_Click(object sender, EventArgs e)
        {
            if (ground.playground[1, 0] != "")
                return;

            if (player1.CurrentPlayer || (player1.FirstTurn && counter == 0))
            {
                if (player1.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 1, 0, player1);
                btn_Field4.Text = player1.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player1))
                    Winner(player1);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player2.Name;
                player2.CurrentPlayer = true;
                player1.CurrentPlayer = false;
            }
            else if (player2.CurrentPlayer || (player2.FirstTurn && counter == 0))
            {
                if (player2.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 1, 0, player2);
                btn_Field4.Text = player2.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player2))
                    Winner(player2);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player1.Name;
                player1.CurrentPlayer = true;
                player2.CurrentPlayer = false;
            }
        }


        /*
         * BUTTON 5
        */
        private void btn_Field5_Click(object sender, EventArgs e)
        {
            if (ground.playground[1, 1] != "")
                return;

            if (player1.CurrentPlayer || (player1.FirstTurn && counter == 0))
            {
                if (player1.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 1, 1, player1);
                btn_Field5.Text = player1.PlayerSign;

                //Win
                if (HelperMethodcs.Win(ground, player1))
                    Winner(player1);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player2.Name;
                player2.CurrentPlayer = true;
                player1.CurrentPlayer = false;
            }
            else if (player2.CurrentPlayer || (player2.FirstTurn && counter == 0))
            {
                if (player2.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 1, 1, player2);
                btn_Field5.Text = player2.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player2))
                    Winner(player2);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player1.Name;
                player1.CurrentPlayer = true;
                player2.CurrentPlayer = false;
            }
        }


        /*
         * BUTTON 6
        */
        private void btn_Field6_Click(object sender, EventArgs e)
        {
            if (ground.playground[1, 2] != "")
                return;

            if (player1.CurrentPlayer || (player1.FirstTurn && counter == 0))
            {
                if (player1.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 1, 2, player1);
                btn_Field6.Text = player1.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player1))
                    Winner(player1);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player2.Name;
                player2.CurrentPlayer = true;
                player1.CurrentPlayer = false;
            }
            else if (player2.CurrentPlayer || (player2.FirstTurn && counter == 0))
            {
                if (player2.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 1, 2, player2);
                btn_Field6.Text = player2.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player2))
                    Winner(player2);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player1.Name;
                player1.CurrentPlayer = true;
                player2.CurrentPlayer = false;
            }
        }


        /*
         * BUTTON 7
        */
        private void btn_Field7_Click(object sender, EventArgs e)
        {
            if (ground.playground[2, 0] != "")
                return;

            if (player1.CurrentPlayer || (player1.FirstTurn && counter == 0))
            {
                if (player1.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 2, 0, player1);
                btn_Field7.Text = player1.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player1))
                    Winner(player1);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player2.Name;
                player2.CurrentPlayer = true;
                player1.CurrentPlayer = false;
            }
            else if (player2.CurrentPlayer || (player2.FirstTurn && counter == 0))
            {
                if (player2.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 2, 0, player2);
                btn_Field7.Text = player2.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player2))
                    Winner(player2);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player1.Name;
                player1.CurrentPlayer = true;
                player2.CurrentPlayer = false;
            }
        }


        /*
         * BUTTON 8
        */
        private void btn_Field8_Click(object sender, EventArgs e)
        {
            if (ground.playground[2, 1] != "")
                return;

            if (player1.CurrentPlayer || (player1.FirstTurn && counter == 0))
            {
                if (player1.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 2, 1, player1);
                btn_Field8.Text = player1.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player1))
                    Winner(player1);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player2.Name;
                player2.CurrentPlayer = true;
                player1.CurrentPlayer = false;
            }
            else if (player2.CurrentPlayer || (player2.FirstTurn && counter == 0))
            {
                if (player2.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 2, 1, player2);
                btn_Field8.Text = player2.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player2))
                    Winner(player2);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player1.Name;
                player1.CurrentPlayer = true;
                player2.CurrentPlayer = false;
            }
        }


        /*
         * BUTTON 9
        */
        private void btn_Field9_Click(object sender, EventArgs e)
        {
            if (ground.playground[2, 2] != "")
                return;

            if (player1.CurrentPlayer || (player1.FirstTurn && counter == 0))
            {
                if (player1.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 2, 2, player1);
                btn_Field9.Text = player1.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player1))
                    Winner(player1);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player2.Name;
                player2.CurrentPlayer = true;
                player1.CurrentPlayer = false;
            }
            else if (player2.CurrentPlayer || (player2.FirstTurn && counter == 0))
            {
                if (player2.FirstTurn)
                    counter += 1;

                HelperMethodcs.SetPlayGround(ground, 2, 2, player2);
                btn_Field9.Text = player2.PlayerSign;

                // Win
                if (HelperMethodcs.Win(ground, player2))
                    Winner(player2);

                // Draw
                if (HelperMethodcs.Draw(ground))
                    Draw();

                tsslAktuellerSpieler.Text = player1.Name;
                player1.CurrentPlayer = true;
                player2.CurrentPlayer = false;
            }
        }


        /*
         * CLEAR BUTTON TEXT
        */
        private void ClearButtonText()
        {
            btn_Field1.Text = btn_Field2.Text = btn_Field3.Text = btn_Field4.Text = btn_Field5.Text = btn_Field6.Text = btn_Field7.Text = btn_Field8.Text = btn_Field9.Text = "";
        }


        /*
         * WINNER
        */
        private void Winner(Player player)
        {
            player.Points = player.Points + 1;
            tsslPunkte.Text = player1.Points + ":" + player2.Points;

            if (MessageBox.Show(player.Name+ " hat gewonnen" + System.Environment.NewLine + "Möchtet Ihr nochmal gegeneinander spielen?", "Gewinner", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (player1.FirstTurn)
                {
                    player2.FirstTurn = true;
                    player1.FirstTurn = false;
                }
                else
                {
                    player2.FirstTurn = false;
                    player1.FirstTurn = true;
                }

                ground = new PlayGround();
                counter = 0;
                ClearButtonText();
            }
            else
            {
                Application.Exit();
            }
        }

        /*
         * DRAW
        */
        private void Draw()
        {
            if (MessageBox.Show("Kein Spieler hat gewonnen" + System.Environment.NewLine + "Möchtet Ihr nochmal gegeneinander spielen?", "Unentschieden", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (player1.FirstTurn)
                {
                    player2.FirstTurn = true;
                    player1.FirstTurn = false;
                }
                else
                {
                    player2.FirstTurn = false;
                    player1.FirstTurn = true;
                }

                ground = new PlayGround();
                counter = 0;
                ClearButtonText();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
