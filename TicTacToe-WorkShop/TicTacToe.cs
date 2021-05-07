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
        //public char player;

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

        public char Choice()
        {
            Console.WriteLine("Enter your choice. \nX \n0");
            char userSign = Convert.ToChar(Console.ReadLine());
            string choice;
            switch (userSign)
            {
                case 'X':
                    choice = "You Chose: X";
                    break;
                case 'O':
                    choice = "You Chose: O";
                    break;
                default:
                    choice = "Invalid Choice";
                    break;
            }
            Console.WriteLine(choice);
            if (choice == "Invalid Choice")
                Choice();
            return userSign;
        }

        public void ShowBoard()
        {
            TicTacToe game = new TicTacToe();
            for (int i = 1; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0}\n", board[i]);
                    if (i != 9)
                        Console.WriteLine("-----------");
                }
                else
                    Console.Write(" {0} |", board[i]);
            }
        }

        public bool PositionCheck(int position)
        {
            if (board[position] == ' ')
                return true;
            else
            {
                Console.WriteLine("Position already occupied");
                return false;
            }
        }

        public void PlayerMovement(char choice)
        {
            Console.WriteLine("Select the position you want to play on");
            int userChoice = int.Parse(Console.ReadLine());
            bool emptyPosition = PositionCheck(userChoice);
            if (emptyPosition == true)
            {
                board[userChoice] = choice;
                ShowBoard();
            }
            else
            {
                Console.WriteLine("Try Again");
                PlayerMovement(choice);
            }
        }
    }
}
