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

        public void Choice()
        {
            Console.WriteLine("Enter your choice. \nX \n0");
            string userChoice = Console.ReadLine();
            string choice;
            switch (userChoice)
            {
                case "X":
                    choice = "You Chose: X";
                    break;
                case "0":
                    choice = "You Chose: 0";
                    break;
                default:
                    choice = "Invalid Choice";
                    break;
            }
            Console.WriteLine(choice);
            if (choice == "Invalid Choice")
                Choice();
        }



    }
}
