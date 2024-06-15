using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Matrix
{
    class IslandPerimeter
    {
        public int IslandPerimeter_(int[][] grid)
        {
            /*
                T= O(m*n)
                S= O(1)
             */
            int[] result = new int[1];
            result[0] = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        checkperim(grid, row - 1, col, result);
                        checkperim(grid, row + 1, col, result);
                        checkperim(grid, row, col - 1, result);
                        checkperim(grid, row, col + 1, result);
                    }
                }
            }

            return result[0];
        }

        public void checkperim(int[][] grid, int row, int col, int[] result)
        {
            if (row < 0 ||
                row == grid.Length ||
                col < 0 ||
                col == grid[row].Length)
            {
                result[0] += 1;
                return;
            }

            if (grid[row][col] == 0)
                result[0] += 1;

            return;
        }

        /*
         FOR LOOP APPROACH - faster

        T= O(n+m)
        S= O(1)
         */
        public int IslandPerimeter2(int[][] grid)
        {
            int result = 0;

            if (grid == null || grid.Length == 0) return 0;

            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    if (grid[r][c] == 1)
                    {
                        result += 4;

                        if (r > 0 && grid[r - 1][c] == 1)
                            result -= 2;
                        if (c > 0 && grid[r][c - 1] == 1)
                            result -= 2;
                    }
                }
            }

            return result;
        }
    }
}
/*
 463. Island Perimeter
Easy

You are given row x col grid representing a map where grid[i][j] = 1 represents land and grid[i][j] = 0 represents water.

Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells).

The island doesn't have "lakes", meaning the water inside isn't connected to the water around the island. One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.

Example 1:

Input: grid = [[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]
Output: 16
Explanation: The perimeter is the 16 yellow stripes in the image above.
Example 2:

Input: grid = [[1]]
Output: 4
Example 3:

Input: grid = [[1,0]]
Output: 4

Constraints:

row == grid.length
col == grid[i].length
1 <= row, col <= 100
grid[i][j] is 0 or 1.
 */
