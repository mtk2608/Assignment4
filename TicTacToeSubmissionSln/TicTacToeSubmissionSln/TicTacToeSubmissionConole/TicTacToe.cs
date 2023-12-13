using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }

        public static string[,] pos = { { "", "", "" }, { "", "", "" }, { "", "", "" } };
        public static string[] position = { "", "", "", "", "", "", "", "", "" };




             public void Run()
             {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE
            pos[0, 0] = position[0];
            pos[0, 1] = position[1];
            pos[0, 2] = position[2];
            pos[1, 0] = position[3];
            pos[1, 1] = position[4];
            pos[1, 2] = position[5];
            pos[2, 0] = position[6];
            pos[2, 1] = position[7];
            pos[2, 2] = position[8];

            int x = 0;
            int o = 0;

            while (true)
            {

                while (true)
                {
                    _boardRenderer.Render();
                    Console.SetCursorPosition(2, 19);

                    Console.Write("Player X");

                    Console.SetCursorPosition(2, 20);

                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);


                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();




                    if (pos[int.Parse(row), int.Parse(column)] == "")
                    {
                        _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
                        pos[int.Parse(row), int.Parse(column)] = "X";
                        x += 1;
                        break;
                    }

                }

                if (pos[0, 0] == "X" && pos[0, 1] == "X" && pos[0, 2] == "X") 
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[1, 0] == "X" && pos[1, 1] == "X" && pos[1, 2] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[2, 0] == "X" && pos[2, 1] == "X" && pos[2, 2] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }

                else if (pos[0, 0] == "X" && pos[1, 1] == "X" && pos[2, 2] == "X") 
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[2, 0] == "X" && pos[1, 1] == "X" && pos[0, 2] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }

                else if (pos[0, 0] == "X" && pos[1, 0] == "X" && pos[2, 0] == "X") 
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[0, 1] == "X" && pos[1, 1] == "X" && pos[2, 1] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[0, 2] == "X" && pos[1, 2] == "X" && pos[2, 2] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }


                if (pos[0, 0] == "O" && pos[0, 1] == "O" && pos[0, 2] == "O") 
                {
                    Console.Clear();
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }
                else if (pos[1, 0] == "O" && pos[1, 1] == "O" && pos[1, 2] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }
                else if (pos[2, 0] == "O" && pos[2, 1] == "O" && pos[2, 2] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }

                else if (pos[0, 0] == "O" && pos[1, 1] == "O" && pos[2, 2] == "O") 
                {
                    Console.Clear();
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }
                else if (pos[2, 0] == "O" && pos[1, 1] == "O" && pos[0, 2] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }

                else if (pos[0, 0] == "O" && pos[1, 0] == "O" && pos[2, 0] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player 0 Wins!!!");
                    break;
                }
                else if (pos[0, 1] == "O" && pos[1, 1] == "O" && pos[2, 1] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player 0 Wins!!!");
                    break;
                }
                else if (pos[0, 2] == "O" && pos[1, 2] == "O" && pos[2, 2] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player 0 Wins!!!");
                    break;
                }

                if (x == 5 & o == 4)
                {
                    Console.Clear();
                    Console.WriteLine("DRAW!!!!");
                    break;
                }

                while (true)
                {
                    _boardRenderer.Render();
                    Console.SetCursorPosition(3, 25);

                    Console.Write("Player O");

                    Console.SetCursorPosition(3, 26);

                    Console.Write("Please Enter Row: ");
                    var row1 = Console.ReadLine();

                    Console.SetCursorPosition(3, 28);


                    Console.Write("Please Enter Column: ");
                    var column1 = Console.ReadLine();

                    if (pos[int.Parse(row1), int.Parse(column1)] == "")
                    {
                        _boardRenderer.AddMove(int.Parse(row1), int.Parse(column1), PlayerEnum.O, true);
                        pos[int.Parse(row1), int.Parse(column1)] = "O";
                        o += 1;
                        break;
                    }

                  
                }
                if (pos[0, 0] == "X" && pos[0, 1] == "X" && pos[0, 2] == "X") 
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[1, 0] == "X" && pos[1, 1] == "X" && pos[1, 2] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[2, 0] == "X" && pos[2, 1] == "X" && pos[2, 2] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }

                else if (pos[0, 0] == "X" && pos[1, 1] == "X" && pos[2, 2] == "X") 
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[2, 0] == "X" && pos[1, 1] == "X" && pos[0, 2] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }

                else if (pos[0, 0] == "X" && pos[1, 0] == "X" && pos[2, 0] == "X") 
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[0, 1] == "X" && pos[1, 1] == "X" && pos[2, 1] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[0, 2] == "X" && pos[1, 2] == "X" && pos[2, 2] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }


                if (pos[0, 0] == "O" && pos[0, 1] == "O" && pos[0, 2] == "O") 
                {
                    Console.Clear();
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }
                else if (pos[1, 0] == "O" && pos[1, 1] == "O" && pos[1, 2] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }
                else if (pos[2, 0] == "O" && pos[2, 1] == "O" && pos[2, 2] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }

                else if (pos[0, 0] == "O" && pos[1, 1] == "O" && pos[2, 2] == "O") 
                {
                    Console.Clear();
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }
                else if (pos[2, 0] == "O" && pos[1, 1] == "O" && pos[0, 2] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }

                else if (pos[0, 0] == "O" && pos[1, 0] == "O" && pos[2, 0] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player 0 Wins!!!");
                    break;
                }
                else if (pos[0, 1] == "O" && pos[1, 1] == "O" && pos[2, 1] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player 0 Wins!!!");
                    break;
                }
                else if (pos[0, 2] == "O" && pos[1, 2] == "O" && pos[2, 2] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("Player 0 Wins!!!");
                    break;
                }

                

            }
             }


    }

        

    }
