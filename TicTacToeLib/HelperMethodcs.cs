using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public static class HelperMethodcs
    {
        public static bool Win(PlayGround ground, Player player)
        {

            if (WinDiagonal(ground, player))
                return true;

            else if (WinHorizontal(ground, player))
                return true;

            else if (WinVertical(ground, player))
                return true;

            return false;
        }


        // Win Diagonal
        private static bool WinDiagonal(PlayGround ground, Player player)
        {
            if (ground.playground[0, 0] == player.PlayerSign && ground.playground[1, 1] == player.PlayerSign && ground.playground[2, 2] == player.PlayerSign)
                return true;
            else if (ground.playground[0, 2] == player.PlayerSign && ground.playground[1, 1] == player.PlayerSign && ground.playground[2, 0] == player.PlayerSign)
                return true;

            return false;
        }

        // Win Horizontal
        private static bool WinHorizontal(PlayGround ground, Player player)
        {
            if (ground.playground[0, 0] == player.PlayerSign && ground.playground[0, 1] == player.PlayerSign && ground.playground[0, 2] == player.PlayerSign)
                return true;
            else if (ground.playground[1, 0] == player.PlayerSign && ground.playground[1, 1] == player.PlayerSign && ground.playground[1, 2] == player.PlayerSign)
                return true;
            else if (ground.playground[2, 0] == player.PlayerSign && ground.playground[2, 1] == player.PlayerSign && ground.playground[2, 2] == player.PlayerSign)
                return true;

            return false;
        }

        // Win Vertical
        private static bool WinVertical(PlayGround ground, Player player)
        {
            if (ground.playground[0, 0] == player.PlayerSign && ground.playground[1, 0] == player.PlayerSign && ground.playground[2, 0] == player.PlayerSign)
                return true;
            else if (ground.playground[0, 1] == player.PlayerSign && ground.playground[1, 1] == player.PlayerSign && ground.playground[2, 1] == player.PlayerSign)
                return true;
            else if (ground.playground[0, 2] == player.PlayerSign && ground.playground[1, 2] == player.PlayerSign && ground.playground[2, 2] == player.PlayerSign)
                return true;

            return false;
        }

        // Draw
        // @return returns false as long as ONE field isnt filled AND we still have no winner. 
        //         returns true if ALL fields are filled AND we still had no winner!
        public static bool Draw(PlayGround ground)
        {
            if(ground.playground[0, 0] != "" && ground.playground[0, 1] != "" && ground.playground[0, 2] != "" && 
               ground.playground[1, 0] != "" && ground.playground[1, 1] != "" && ground.playground[1, 2] != "" && 
               ground.playground[2, 0] != "" && ground.playground[2, 1] != "" && ground.playground[2, 2] != "")
            {
                return true;
            }

            return false;
        }

        // Set Playground
        public static void SetPlayGround(PlayGround ground, int x, int y, Player player)
        {
            ground.playground[x, y] = player.PlayerSign;
        }
    }
}
