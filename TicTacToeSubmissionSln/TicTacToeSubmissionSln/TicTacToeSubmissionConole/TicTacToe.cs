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
        


 
                 
        public int x = 0;
        public int o = 0;


             public void Run()
             {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE
             while (true)
              {
                Console.SetCursorPosition(2, 19);

                Console.Write("Player X");

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                string row = Console.ReadLine();

                Console.SetCursorPosition(2, 22);


                Console.Write("Please Enter Column: ");
                string column = Console.ReadLine();
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
                x += 1;

                if (x == 5)
                {
                    break;
                }

                Console.SetCursorPosition(2, 19);

                Console.Write("Player O");

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                row = Console.ReadLine();

                Console.SetCursorPosition(2, 22);


                Console.Write("Please Enter Column: ");
                column = Console.ReadLine();
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);
                o += 1;

                if (o == 5)
                {
                    break;
                }

                 static int CheckWin()
                {
                    return 0;
                }

            }
             }


    }

        /*public void Run()
        {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(2, 19);

            Console.Write("Player X");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);           

        }*/

    }
