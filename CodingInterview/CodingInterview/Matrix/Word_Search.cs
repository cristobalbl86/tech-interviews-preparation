using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    class _37_Word_Search
    {
        /*
         * 79. Word Search
         Given a 2D board and a word, find if the word exists in the grid.

The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once.

Example:

board =
[
  ['A','B','C','E'],
  ['S','F','C','S'],
  ['A','D','E','E']
]

Given word = "ABCCED", return true.
Given word = "SEE", return true.
Given word = "ABCB", return false.
             */
        public class Solution
        {
            public static bool Exist(char[][] board, string word)
            {

                for (int row = 0; row < board.Length; row++)
                {
                    for (int col = 0; col < board[row].Length; col++)
                    {
                        if (board[row][col] == word[0] && dfs(board, row, col, 0, word))
                        {
                            return true;
                        }
                    }
                }

                return false;

            }

            public static bool dfs(char[][] board, int row, int col, int letterIndex, string word)
            {
                if (letterIndex == word.Length)
                    return true;

                if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length || board[row][col] != word[letterIndex])
                {
                    return false;
                }

                char temp = board[row][col];
                board[row][col] = ' ';

                bool found =
                    dfs(board, row, col + 1, letterIndex + 1, word) ||
                    dfs(board, row, col - 1, letterIndex + 1, word) ||
                    dfs(board, row + 1, col, letterIndex + 1, word) ||
                    dfs(board, row - 1, col, letterIndex + 1, word);

                board[row][col] = temp;

                return found;

            }
        }

        public class Solution2 
        {
            /*MYSELFT - Time Limit exceeded =( */
            public bool Exist(char[][] board, string word)
            {

                for (int r = 0; r < board.Length; r++)
                {
                    for (int c = 0; c < board[r].Length; c++)
                    {
                        if (word[0] == board[r][c])
                        {
                            if (dfs(board, word, "", r, c))
                                return true;
                        }
                    }
                }

                return false;
            }

            public bool dfs(char[][] board, string target, string current, int r, int c)
            {

                if (target == current) return true;

                if (r < 0 || r >= board.Length || c < 0 || c >= board[r].Length ||
                  target.IndexOf(current) == -1)
                {
                    return false;
                }

                string temp = board[r][c].ToString();
                board[r][c] = '.';

                bool res =
                    dfs(board, target, current + temp, r + 1, c) ||
                    dfs(board, target, current + temp, r - 1, c) ||
                    dfs(board, target, current + temp, r, c + 1) ||
                    dfs(board, target, current + temp, r, c - 1);

                board[r][c] = char.Parse(temp);

                return res;
            }

        }

        public class Solution3
        {
            /*MYSELF TOO*/
            public bool Exist(char[][] board, string word)
            {

                for (int r = 0; r < board.Length; r++)
                {
                    for (int c = 0; c < board[r].Length; c++)
                    {
                        if (word[0] == board[r][c])
                        {
                            if (dfs(board, word, 0, r, c))
                                return true;
                        }
                    }
                }

                return false;
            }

            public bool dfs(char[][] board, string target, int index, int r, int c)
            {
                if (r < 0 || r >= board.Length || c < 0 || c >= board[r].Length || board[r][c] != target[index])
                    return false;

                if (index == target.Length - 1 && board[r][c] == target[index])
                    return true;

                char temp = board[r][c];
                board[r][c] = '.';

                bool res = dfs(board, target, index + 1, r + 1, c)
                    || dfs(board, target, index + 1, r - 1, c)
                    || dfs(board, target, index + 1, r, c + 1)
                    || dfs(board, target, index + 1, r, c - 1);

                board[r][c] = temp;

                return res;
            }

        }
    }
}
