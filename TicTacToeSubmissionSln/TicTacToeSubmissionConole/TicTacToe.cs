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
            while (nrMoves != 0 || )
            {
                Play(PlayerEnum.X);
                Play(PlayerEnum.O);
            }
            if (nrMoves == 0) {
                Console.WriteLine("The game ends in a draw!!");
            }
            if (CheckWin(PlayerEnum.O)
                {
                Console.WriteLine("Congratulations!!! Player O wins :)");
            }
            if ()
            {

            }
        }
        private void Play(PlayerEnum player)
        {
            Console.SetCursorPosition(2, 19);

            Console.Write("Player X");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);

            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();

            if (!CheckSpace(int.Parse(row),int.Parse(column)))
            {
                //Add move
                AddRecord(row,column,player);
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column),player, true);
            }else
            {
                while (CheckSpace(int.Parse(row),int.Parse(column)))
                {
                    //Add row:
                    Console.Write("Please Enter an empty Row: ");
                    row = Console.ReadLine();

                    //Add column:
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
                return false;
            }else
            {
                return true;
            }  
        }
        private void AddRecord(string row, string col,PlayerEnum player)
        {
            movesTrack[int.Parse(row), int.Parse(col)] = player.ToString();
        }

        private bool CheckWin(PlayerEnum player)
        {
            string x,y,z;  

            if ()
            {
                
            }

            if (true)
            {

            }
            return true;
        }
    }
}
