using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeSubmissionConsole
{
    /*internal class Example2
    {
        static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        static int player = 1; // Player 1 starts
        static int choice; // Chosen position on the board

        static int flag = 0; // Flag to check if the game is over

        // Main method
        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); // Whenever the loop restarts, clear the console
                Console.WriteLine("Player 1: X and Player 2: O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Turn Player 2");
                }
                else
                {
                    Console.WriteLine("Turn Player 1");
                }
                Console.WriteLine("\n");
                Board(); // Draw the board

                // Check if the chosen position is already marked
                bool validInput = false;
                while (!validInput)
                {
                    bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                    if (isNumber && choice >= 1 && choice <= 9 && board[choice - 1] == ' ')
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose an empty position (1-9).");
                    }
                }

                // Mark the chosen position with the respective player's symbol
                if (player % 2 == 0)
                {
                    board[choice - 1] = 'O';
                    player++;
                }
                else
                {
                    board[choice - 1] = 'X';
                    player++;
                }

                flag = CheckWin(); // Check if any player has won

            } while (flag != 1 && flag != -1); // Continue the game until there is a winner or a draw

            Console.Clear(); // Clear the console
            Board(); // Draw the final board

            // Print the result
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won!", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.ReadLine();
        }

        // Method to draw the board
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
            Console.WriteLine("     |     |      ");
        }

        // Method to check if any player has won
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            // Winning Condition For First Row
            if (board[0] == board[1] && board[1] == board[2] && board[0] != ' ')
            {
                return 1;
            }
            // Winning Condition For Second Row
            else if (board[3] == board[4] && board[4] == board[5] && board[3] != ' ')
            {
                return 1;
            }
            // Winning Condition For Third Row
            else if (board[6] == board[7] && board[7] == board[8] && board[6] != ' ')
            {
                return 1;
            }
            #endregion

            #region Vertical Winning Condtion
            // Winning Condition For First Column
            else if (board[0] == board[3] && board[3] == board[6] && board[0] != ' ')
            {
                return 1;
            }
            // Winning Condition For Second Column
            else if (board[1] == board[4] && board[4] == board[7] && board[1] != ' ')
            {
                return 1;
            }
            // Winning Condition For Third Column
            else if (board[2] == board[5] && board[5] == board[8] && board[2] != ' ')
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            else if (board[0] == board[4] && board[4] == board[8] && board[0] != ' ')
            {
                return 1;
            }
            else if (board[2] == board[4] && board[4] == board[6] && board[2] != ' ')
            {
                return 1;
            }
            #endregion

            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (board[0] != ' ' && board[1] != ' ' && board[2] != ' ' && board[3] != ' ' && board[4] != ' ' && board[5] != ' ' && board[6] != ' ' && board[7] != ' ' && board[8] != ' ')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }
    }
}*/
    }