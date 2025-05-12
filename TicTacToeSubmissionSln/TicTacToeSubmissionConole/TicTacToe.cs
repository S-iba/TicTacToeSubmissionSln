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
            Play(PlayerEnum.X);
            Play(PlayerEnum.O);
        }
        private void Play(PlayerEnum player)
        {
            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(2, 19);

            Console.Write("Player X");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);
            // do a loop

            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();

            if (!CheckSpace(int.Parse(row),int.Parse(column)))
            {
            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)

                _boardRenderer.AddMove(int.Parse(row), int.Parse(column),player, true);
            }else
            {
                while (CheckSpace(int.Parse(row),int.Parse(column)))
                {
                    Console.Write("Please Enter Row: ");
                    row = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);
                    // do a loop

                    Console.Write("Please Enter Column: ");
                    column = Console.ReadLine();
                }
            }
            
        }

        private bool CheckSpace(int row, int col)
        {
            if (movesTrack[row,col] == "-")
            {
                return false;
            }else
            {
                return true;
            }
            
        }

        private void AddRecord(string row, string col,PlayerEnum player)
        {
            movesTrack[int.Parse(row), int.Parse(col)] = player;
        }
    }
}
