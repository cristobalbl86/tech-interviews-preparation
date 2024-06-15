using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Matrix
{
    class MaxAreaOfIsland
    {
        /*
            T= O(m*n)
            S= O(m*n)
         */
        public int MaxAreaOfIsland_(int[][] grid)
        {

            if (grid == null || grid.Length == 0) return 0;

            int iresult = 0;
            int maxarea = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {

                    if (grid[row][col] == 1)
                    {
                        iresult = checkarea(grid, row, col);
                        if (iresult > maxarea)
                            maxarea = iresult;
                    }

                }
            }

            return maxarea;
        }

        public int checkarea(int[][] grid, int r, int c)
        {
            //check if out of bound or is water (0)
            if (r < 0 || r > grid.Length - 1 ||
              c < 0 || c > grid[r].Length - 1 ||
              grid[r][c] == 0)
            {
                return 0;
            }

            //change cell to don't count it later again
            grid[r][c] = 0;

            //check all directions and ADD results + 1
            return checkarea(grid, r - 1, c) +
                checkarea(grid, r + 1, c) +
                checkarea(grid, r, c - 1) +
                checkarea(grid, r, c + 1) + 1;
        }
    }
}
/*
 695. Max Area of Island
Medium

Given a non-empty 2D array grid of 0's and 1's, an island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.

Find the maximum area of an island in the given 2D array. (If there is no island, the maximum area is 0.)

Example 1:

[[0,0,1,0,0,0,0,1,0,0,0,0,0],
 [0,0,0,0,0,0,0,1,1,1,0,0,0],
 [0,1,1,0,1,0,0,0,0,0,0,0,0],
 [0,1,0,0,1,1,0,0,1,0,1,0,0],
 [0,1,0,0,1,1,0,0,1,1,1,0,0],
 [0,0,0,0,0,0,0,0,0,0,1,0,0],
 [0,0,0,0,0,0,0,1,1,1,0,0,0],
 [0,0,0,0,0,0,0,1,1,0,0,0,0]]
Given the above grid, return 6. Note the answer is not 11, because the island must be connected 4-directionally.
Example 2:

[[0,0,0,0,0,0,0,0]]
Given the above grid, return 0.
Note: The length of each dimension in the given grid does not exceed 50.
 */
