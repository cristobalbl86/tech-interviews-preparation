using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    /*
     * 
     * 64. Minimum Path Sum
     Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.

Note: You can only move either down or right at any point in time.

Example:

Input:
[
  [1,3,1],
  [1,5,1],
  [4,2,1]
]
Output: 7
Explanation: Because the path 1→3→1→1→1 minimizes the sum.
         */
    class Minimun_Path_Sum
    {
        /**
         KEVIN APPROACH - Iterative and new matrix
            T= O(m+n)
            S= O(n)
         */
        public static int MinPathSum(int[][] grid)
        {
            if (grid == null || grid[0].Length == 0)
            {
                return 0;
            }

            int[,] matrix = new int[grid.Length, grid[0].Length];

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    matrix[row, col] += grid[row][col];

                    if (row > 0 && col > 0)
                    {
                        matrix[row, col] += Math.Min(
                            matrix[row - 1, col], matrix[row, col - 1]
                        );
                    }
                    else if (row > 0)
                    {
                        matrix[row, col] += matrix[row - 1, col];
                    }
                    else if (col > 0)
                    {
                        matrix[row, col] += matrix[row, col - 1];
                    }
                }
            }

            return matrix[grid.Length - 1, grid[0].Length - 1];
        }
        /*
         RECURSION APPROACH - Verifies top & left for all elements
            T= O(m+n)
            S= O(1)
         */
        public int MinPathSum_2(int[][] grid)
        {
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[r].Length; c++)
                {
                    if (r == 0 && c == 0) continue;

                    int left = checkpath(grid, r, c - 1);
                    int top = checkpath(grid, r - 1, c);

                    grid[r][c] += Math.Min(left, top);
                }
            }

            return grid[grid.Length - 1][grid[0].Length - 1];
        }

        public int checkpath(int[][] grid, int r, int c)
        {
            if (r < 0 || c < 0 || r > grid.Length || c > grid[r].Length)
                return int.MaxValue;

            return grid[r][c];
        }

        /*ITERATIVE APPROACH - No extra space
            T= O(m+n)
            S= O(1)
         */
        public int MinPathSum_3(int[][] grid)
        {
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[r].Length; c++)
                {
                    if (r == 0 && c == 0) continue;

                    if (r > 0 && c > 0)
                    {
                        grid[r][c] += Math.Min(
                            grid[r][c - 1],
                            grid[r - 1][c]);
                    }
                    else if (r > 0)
                    {
                        grid[r][c] += grid[r - 1][c];
                    }
                    else
                    {
                        grid[r][c] += grid[r][c - 1];
                    }
                }
            }
            return grid[grid.Length - 1][grid[0].Length - 1];
        }
    }
}
