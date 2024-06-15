using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Microsoft
{
    class SudokuSolver
    {
        public void SolveSudoku(char[][] board)
        {
            HashSet<char> hsrow = new HashSet<char>();
            HashSet<char> hscol = new HashSet<char>();
            HashSet<char> hsbox = new HashSet<char>();

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[0].Length; col++)
                {
                    if (board[row][col] != '.')
                    {
                        //go from 1to10

                        //validate num against row (row, board)
                        //validate num against col (col, board)
                        //validate num against box (row, col, board)
                    }
                }
            }
        }
    }
}
