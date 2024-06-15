using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    /*
     * 63. Unique Paths II
     A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).
Now consider if some obstacles are added to the grids. How many unique paths would there be?

An obstacle and empty space is marked as 1 and 0 respectively in the grid.

Note: m and n will be at most 100.

Example 1:

Input:
[
  [0,0,0],
  [0,1,0],
  [0,0,0]
]
Output: 2
Explanation:
There is one obstacle in the middle of the 3x3 grid above.
There are two ways to reach the bottom-right corner:
1. Right -> Right -> Down -> Down
2. Down -> Down -> Right -> Right
         
         */
    class _32_Unique_PathsII
    {
        public static int Main_32_unique_PathsII(int[][] obstacleGrid)
        {
            if (obstacleGrid == null || obstacleGrid.Length == 0 || obstacleGrid[0][0] == 1)
                return 0;

            int rows = obstacleGrid.Length;
            int cols = obstacleGrid[0].Length;

            int[,] matrix = new int[rows, cols];

            //1s to the first col, break if found a block "1"
            for (int r = 0; r < rows; r++)
            {
                if (obstacleGrid[r][0] == 1)
                    break;
                else
                    matrix[r, 0] = 1;
            }
            //1s to the first row, break if found a block "1"
            for (int c = 0; c < cols; c++)
            {
                if (obstacleGrid[0][c] == 1)
                    break;
                else
                    matrix[0, c] = 1;
            }

            for (int r = 1; r < rows; r++)
            {
                for (int c = 1; c < cols; c++)
                {
                    if (obstacleGrid[r][c] == 1)
                    {
                        //matrix[r, c] = 0;
                        continue;
                    }
                    matrix[r, c] = matrix[r, c - 1] + matrix[r - 1, c];
                }
            }

            return matrix[rows - 1, cols - 1];
        }
    }
}
