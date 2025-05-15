using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private int nrMoves = 9;
        string[,] movesTrack = { { "-", "-", "-" }, { "-", "-", "-" }, { "-", "-", "-" } };
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }
        public void Run()
        {
            while (nrMoves != 1)
            {
                Play(PlayerEnum.X);
                Play(PlayerEnum.O);
              
                if (CheckWin(PlayerEnum.X))
                {
                    break;
                }
                if (CheckWin(PlayerEnum.O))
                {
                    break ;
                }
                nrMoves -= 2 ;
            }

            //Chek for Draw, Win, or Loss...
            if (nrMoves == 1)
            {
                Console.SetCursorPosition(2, 25);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The game ends in a draw!!");
            }
            if (CheckWin(PlayerEnum.O))
            {
                Console.SetCursorPosition(2, 25);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations!!! Player O wins :)");
            }
            if (CheckWin(PlayerEnum.X))
            {
                Console.SetCursorPosition(2, 25);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations!!! Player X wins :)");
            }
        }
        private void Play(PlayerEnum player)
        {
            Console.SetCursorPosition(2, 19);

            Console.Write($"Player {player.ToString()}");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);

            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();

            if (CheckSpace(int.Parse(row),int.Parse(column)))
            {
                //Add move
                AddRecord(row,column,player);
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column),player, true);
            }else
            {
                while (!CheckSpace(int.Parse(row),int.Parse(column)))
                {
                    //Add row:
                    Console.SetCursorPosition(2, 23);
                    Console.Write("Please Enter an empty Row: ");
                    row = Console.ReadLine();

                    //Add column:
                    Console.SetCursorPosition(2, 24);
                    Console.Write("Please Enter an empty Column: ");
                    column = Console.ReadLine();
                }
                AddRecord(row, column, player);
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), player, true);
            }   
        }
        private bool CheckSpace(int row, int col)
        {
            if (movesTrack[row,col] == "-")
            {
                return true;
            }else
            {
                return false;
            }  
        }
        private void AddRecord(string row, string col,PlayerEnum player)
        {
            movesTrack[int.Parse(row), int.Parse(col)] = player.ToString();
        }

        private bool CheckWin(PlayerEnum player)
        {
            string x,y,z;
            //Horizontal - First row
            x = movesTrack[0, 0];
            y = movesTrack[0, 1];
            z = movesTrack[0, 2];
            if (x == player.ToString() && x == y && y == z )
            {
                return true;  
            }

            //Diagonal Left-To_Right
            x = movesTrack[0, 0];
            y = movesTrack[1, 1];
            z = movesTrack[2, 2];
            if (x == player.ToString() && x == y && y == z)
            {
                return true;
            }

            //Diagonal Right-To-Left
            x = movesTrack[0, 2];
            y = movesTrack[1, 1];
            z = movesTrack[2, 0];
            if (x == player.ToString() && x == y && y == z)
            {
                return true;
            }

            //Horizontal - Second row
            x = movesTrack[1, 0];
            y = movesTrack[1, 1];
            z = movesTrack[1, 2];
            if (x == player.ToString() && x == y && y == z)
            {
                return true;
            }

            //Horizontal - Third row
            x = movesTrack[2, 0];
            y = movesTrack[2, 1];
            z = movesTrack[2, 2];
            if (x == player.ToString() && x == y && y == z)
            {
                return true;
            }

            //Vertical - First Column
            x = movesTrack[0, 0];
            y = movesTrack[1, 0];
            z = movesTrack[2, 0];
            if (x == player.ToString() && x == y && y == z)
            {
                return true;
            }

            //Vertical - Second Column
            x = movesTrack[0, 1];
            y = movesTrack[1, 1];
            z = movesTrack[2, 1];
            if (x == player.ToString() && x == y && y == z)
            {
                return true;
            }

            //Vertical - Third Column
            x = movesTrack[0, 2];
            y = movesTrack[1, 2];
            z = movesTrack[2, 2];
            if (x == player.ToString() && x == y && y == z)
            {
                return true;
            }
            return false;
        }
    }
}
