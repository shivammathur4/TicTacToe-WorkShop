using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_WorkShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TicTacToe");
            TicTacToe game = new TicTacToe();
            game.CreateBoard();
            game.Choice();
        }
    }
}
