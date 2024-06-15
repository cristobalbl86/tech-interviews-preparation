using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Microsoft
{
    class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {

            if (!validaterows(board))
                return false;

            if (!validatecols(board))
                return false;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (!validatebox(3 * row, 3 * col, board))
                        return false;
                }
            }

            return true;
        }

        public bool validaterows(char[][] board)
        {
            for (int row = 0; row < board.Length; row++)
            {
                HashSet<char> hs = new HashSet<char>();
                for (int col = 0; col < board[0].Length; col++)
                {
                    if (board[row][col] != '.' && hs.Contains(board[row][col]))
                    {
                        return false;
                    }
                    hs.Add(board[row][col]);
                }
            }
            return true;
        }

        public bool validatecols(char[][] board)
        {
            for (int col = 0; col < board[0].Length; col++)
            {
                HashSet<char> hs = new HashSet<char>();
                for (int row = 0; row < board.Length; row++)
                {
                    if (board[col][row] != '.' && hs.Contains(board[col][row]))
                    {
                        return false;
                    }
                    hs.Add(board[col][row]);
                }
            }
            return true;
        }

        public bool validatebox(int strow, int stcol, char[][] board)
        {
            HashSet<char> hs = new HashSet<char>();
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[strow + row][stcol + col] != '.' && hs.Contains(board[strow + row][stcol + col]))
                        return false;

                    hs.Add(board[strow + row][stcol + col]);
                }
            }

            return true;
        }
    }
}
/*
 Runtime: 108 ms, faster than 79.83% of C# online submissions for Valid Sudoku.
Memory Usage: 28.4 MB, less than 5.47% of C# online submissions for Valid Sudoku.

36. Valid Sudoku
Medium

Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
Note:

A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.
 

Example 1:


Input: board = 
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: true
Example 2:

Input: board = 
[["8","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
 */
