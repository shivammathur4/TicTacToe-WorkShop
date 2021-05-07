using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_WorkShop
{
    class TicTacToe
    {
        public char[] board;

        public TicTacToe()
        {
            board = new char[10];
        }
        public void CreateBoard()
        {
            TicTacToe game = new TicTacToe();
            for (int position = 1; position < 10; position++)
            {
                game.board[position] = ' ';
            }
        }



    }
}
