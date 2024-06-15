using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    class _13_Number_Clusters_Matrix_AO
    {
        /*NUMBER OF ISLANDS
         * Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

Example 1:
Input:
11110
11010
11000
00000
Output: 1
         * Runtime: 108 ms, faster than 81.12% of C# online submissions for Number of Islands.
            Memory Usage: 27.4 MB, less than 98.87% of C# online submissions for Number of Islands.
         */

        public static int NumIslands(char[][] grid)
        {
            int nIslands = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[0].Length; col++)
                {
                    if (grid[row][col] == '1')
                    {
                        nIslands++;
                        checkAdj(grid, row, col);
                    }
                }
            }

            return nIslands;
        }

        public static void checkAdj(char[][] grid, int r, int c)
        {
            if (r < 0 || r == grid.Length || c < 0 || c == grid[0].Length
              || grid[r][c] == '0') return;

            grid[r][c] = '0';
            checkAdj(grid, r - 1, c);
            checkAdj(grid, r + 1, c);
            checkAdj(grid, r, c - 1);
            checkAdj(grid, r, c + 1);

            return;
        }
    }
}
