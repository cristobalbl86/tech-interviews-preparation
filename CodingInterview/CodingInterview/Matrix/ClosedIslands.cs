using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Matrix
{
    class ClosedIslands
    {
        /*
            T= O(m*n)
            S= O(m*n)
         */
        public int ClosedIsland(int[][] grid)
        {
            int closed = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {

                    if (grid[row][col] == 0)
                    {
                        if (checkclosed(grid, row, col))
                            closed++;
                    }
                }
            }

            return closed;
        }

        public bool checkclosed(int[][] grid, int row, int col)
        {
            //out of bound OR
            //1 / -1
            if (row < 0 || row == grid.Length || col < 0 || col == grid[0].Length
                  || grid[row][col] == 1
                  || grid[row][col] == -1)
            {
                return true;
            }

            //matrix perimeter
            if (row == 0 ||
               row == grid.Length - 1 ||
               col == 0 ||
               col == grid[row].Length - 1)
            {
                return false;
            }

            grid[row][col] = -1;

            //check all directions
            bool up = checkclosed(grid, row - 1, col);
            bool down = checkclosed(grid, row + 1, col);
            bool left = checkclosed(grid, row, col - 1);
            bool right = checkclosed(grid, row, col + 1);

            return up && down && left && right;
        }
    }
}
/*
 1254. Number of Closed Islands
Medium

Given a 2D grid consists of 0s (land) and 1s (water).  An island is a maximal 4-directionally connected group of 0s and a closed island is an island totally (all left, top, right, bottom) surrounded by 1s.

Return the number of closed islands.

Example 1:

Input: grid = [[1,1,1,1,1,1,1,0],[1,0,0,0,0,1,1,0],[1,0,1,0,1,1,1,0],[1,0,0,0,0,1,0,1],[1,1,1,1,1,1,1,0]]
Output: 2
Explanation: 
Islands in gray are closed because they are completely surrounded by water (group of 1s).
Example 2:

Input: grid = [[0,0,1,0,0],[0,1,0,1,0],[0,1,1,1,0]]
Output: 1
Example 3:

Input: grid = [[1,1,1,1,1,1,1],
               [1,0,0,0,0,0,1],
               [1,0,1,1,1,0,1],
               [1,0,1,0,1,0,1],
               [1,0,1,1,1,0,1],
               [1,0,0,0,0,0,1],
               [1,1,1,1,1,1,1]]
Output: 2

Constraints:

1 <= grid.length, grid[0].length <= 100
0 <= grid[i][j] <=1
 */
