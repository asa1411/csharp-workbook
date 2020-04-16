using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        //board of nested array, big one for row and nested one for column
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {

            while (!CheckForWin() && !CheckForTie())
            {
                DrawBoard();
                GetInput();

            }

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {

            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row, column);//pass row and column to PlaceMark method
        }

        public static void PlaceMark(int row, int column)
        {

            // when the user enters row and column on the already filled cell, the entry will not be accepted.
            if (board[row][column] == "X" || board[row][column] == "O")
            {
                Console.WriteLine("This cell is already filled. Try again");
            }
            else
            {//when the user enters a mark on an empty cell, it will be marked and player will take turn.
             //before player turns, check if a player wins.

                board[row][column] = playerTurn;

                playerTurn = (playerTurn == "X") ? "O" : "X";//ternary condition to switch player turn
            }


        }

        public static bool CheckForWin()
        {
            // declare boolean variable for each win and make a condition of any winning to print the player won and execute DrawBoard method to enter the last mark
            bool HW = HorizontalWin();
            bool VW = VerticalWin();
            bool DW = DiagonalWin();
            if (HW || VW || DW)
            {
                Console.WriteLine("Player " + playerTurn + " won!");

                return true;
            }
            else
            { return false; }


        }
        public static bool CheckForTie()
        {
            // Since winning is already declared, any other filling of all 9 cells without win is tie. Boolean method should be returned true to make any execution
            if ((board[0][0] == "X" || board[0][0] == "O") &&
            (board[0][1] == "X" || board[0][1] == "O") &&
            (board[0][2] == "X" || board[0][2] == "O") &&
            (board[1][0] == "X" || board[1][0] == "O") &&
            (board[1][1] == "X" || board[1][1] == "O") &&
            (board[1][2] == "X" || board[1][2] == "O") &&
            (board[2][0] == "X" || board[2][0] == "O") &&
            (board[2][1] == "X" || board[2][1] == "O") &&
            (board[2][2] == "X" || board[2][2] == "O"))
            {
                Console.WriteLine("It's a tie.");
                return true;

            }

            return false;
        }

        public static bool HorizontalWin()
        {//If three cells of each row are entered by playerTurn which is either O or X, it is declared "win"
            if (
                (board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn
               ) ||
            (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn
               ) ||
            (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn
             ))
                return true;

            else { return false; }
        }

        public static bool VerticalWin()
        {
            if ((board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn
            )
            || (board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn
            ) ||
             (board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn
            ))
                return true;
            else { return false; }
        }

        public static bool DiagonalWin()
        {
            if ((board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn
            ) ||
            (board[0][2] == playerTurn && board[1][1] == playerTurn && board[2][0] == playerTurn
            ))
                return true;
            else { return false; }
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }

    }
}
