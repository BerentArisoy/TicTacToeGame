using System;

namespace TicTacToe
{
    class Program
    {
        static int[] board = new int[9];
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = 0;
            }

            int userTurn = -1;
            int computerTurn = -1;
            Random rand = new Random();

            while (checkForWinner() == 0)
            {
                while (userTurn == -1 || board[userTurn] != 0)
                {
                    Console.WriteLine("Enter a number from 0 to 8");
                    userTurn = int.Parse(Console.ReadLine());
                    Console.WriteLine("You Typed " + userTurn);
                }
                board[userTurn] = 1;
                // don't let the computer pick an invalid number
                while (computerTurn == -1 || board[computerTurn] != 0)
                {
                    computerTurn = rand.Next(8);
                    Console.WriteLine("Computer chooses " + computerTurn);
                }
                board[computerTurn] = 2;
                printBoard();
            }

            Console.WriteLine("Player " + checkForWinner() + " Won The Game!");


        }

        private static int checkForWinner()
        {
            // return a 0 if nobody won. Return the player number if they won.
            // top row.
            if (board[0] == board[1] && board[1] == board[2])
            {
                return board[0];
            }

            // second row.
            if (board[3] == board[4] && board[4] == board[5])
            {
                return board[3];
            }

            // third row.
            if (board[6] == board[7] && board[7] == board[8])
            {
                return board[6];
            }

            // first column.
            if (board[0] == board[3] && board[3] == board[6])
            {
                return board[0];
            }

            // second column.
            if (board[1] == board[4] && board[4] == board[7])
            {
                return board[1];
            }

            // third column.
            if (board[2] == board[5] && board[5] == board[8])
            {
                return board[2];
            }

            // first diagonal.
            if (board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }

            // second diagonal.
            if (board[2] == board[4] && board[4] == board[6])
            {
                return board[2];
            }
            return 0;
        }


        private static void printBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                // Console.WriteLine("Square " + i + " contains " + board[i]);
                // print x or o for each squre
                // 0 means unoccupied. 1 means player 1 (X) , 2 means player 2 (O)
                if (board[i] == 0)
                {
                    Console.Write(".");
                }
                if (board[i] == 1)
                {
                    Console.Write("X");
                }
                if (board[i] == 2)
                {
                    Console.Write("O");
                }
                // print a new line every 3rd character
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}