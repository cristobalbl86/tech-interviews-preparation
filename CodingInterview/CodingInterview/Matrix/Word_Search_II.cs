using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Matrix
{
    class Word_Search_II
    {
        public class MyFirstTry
        {
            /*248 ms AND DOES NOT WORK FOR ALL CASES*/
            public IList<string> FindWords(char[][] board, string[] words)
            {

                var result = new HashSet<string>();

                int m = board.Length;
                int n = board[0].Length;

                for (int row = 0; row < m; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        int[,] visited = new int[m, n];
                        dfs(board, visited, row, col, "", result, words);
                    }
                }

                return result.ToList();
            }

            public void dfs(char[][] board, int[,] visited, int r, int c, string current, HashSet<string> res, string[] words)
            {

                if (r < 0 || c < 0 || r == board.Length || c == board[0].Length ||
                    visited[r, c] == 1)
                    return;

                string word = current + board[r][c].ToString();

                bool found = false;
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].IndexOf(word) != -1)
                    {
                        found = true;
                        if (words[i] == word && !res.Contains(word))
                        {
                            res.Add(word);
                        }
                    }
                }

                if (!found)
                    return;

                visited[r, c] = 1;

                dfs(board, visited, r - 1, c, word, res, words);
                dfs(board, visited, r + 1, c, word, res, words);
                dfs(board, visited, r, c - 1, word, res, words);
                dfs(board, visited, r, c + 1, word, res, words);
            }

        }

        public class My2ndTry
        {
            /*Very Slow 2660ms*/
            public IList<string> FindWords(char[][] board, string[] words)
            {
                var result = new HashSet<string>();

                int m = board.Length;
                int n = board[0].Length;

                for (int row = 0; row < m; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        foreach (string word in words)
                        {
                            if (word[0] == board[row][col])
                            {
                                if (dfs(board, row, col, word, 0) && !result.Contains(word))
                                    result.Add(word);
                            }
                        }

                    }
                }

                return result.ToList();
            }

            public bool dfs(char[][] board, int r, int c, string target, int index)
            {

                if (target.Length == index) return true;

                if (r < 0 || c < 0 || r >= board.Length || c >= board[0].Length ||
                  board[r][c] != target[index])
                    return false;

                char temp = board[r][c];
                board[r][c] = '.';

                bool res = dfs(board, r - 1, c, target, index + 1) ||
                    dfs(board, r + 1, c, target, index + 1) ||
                    dfs(board, r, c + 1, target, index + 1) ||
                    dfs(board, r, c - 1, target, index + 1);

                board[r][c] = temp;

                return res;
            }

        }
    }
}
/*
 212. Word Search II
Hard

Given an m x n board of characters and a list of strings words, return all words on the board.

Each word must be constructed from letters of sequentially adjacent cells, where adjacent cells are horizontally or vertically neighboring. The same letter cell may not be used more than once in a word.

 

Example 1:


Input: board = [["o","a","a","n"],["e","t","a","e"],["i","h","k","r"],["i","f","l","v"]], words = ["oath","pea","eat","rain"]
Output: ["eat","oath"]
Example 2:


Input: board = [["a","b"],["c","d"]], words = ["abcb"]
Output: []
 

Constraints:

m == board.length
n == board[i].length
1 <= m, n <= 12
board[i][j] is a lowercase English letter.
1 <= words.length <= 3 * 104
1 <= words[i].length <= 10
words[i] consists of lowercase English letters.
All the strings of words are unique.
 */
