using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    /*
994. Rotting Oranges
Medium

In a given grid, each cell can have one of three values:

the value 0 representing an empty cell;
the value 1 representing a fresh orange;
the value 2 representing a rotten orange.
Every minute, any fresh orange that is adjacent (4-directionally) to a rotten orange becomes rotten.

Return the minimum number of minutes that must elapse until no cell has a fresh orange.  If this is impossible, return -1 instead.

Example 1:

Input: [[2,1,1],[1,1,0],[0,1,1]]
Output: 4
Example 2:

Input: [[2,1,1],[0,1,1],[1,0,1]]
Output: -1
Explanation:  The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.
Example 3:

Input: [[0,2]]
Output: 0
Explanation:  Since there are already no fresh oranges at minute 0, the answer is just 0.
 

Note:
1 <= grid.length <= 10
1 <= grid[0].length <= 10
grid[i][j] is only 0, 1, or 2.     
         */
    class _57_Rotting_Oranges
    {
        public int OrangesRotting(int[][] grid)
        {

            int minutes = 0;
            int rotten = 0, fresh = 0;
            int rottenInMinute = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;

            var rottenQueue = new Queue<(int R, int C)>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        fresh++;
                    }
                    else if (grid[i][j] == 2)
                    {
                        rotten++;
                        rottenQueue.Enqueue((i, j));
                    }
                }
            }

            var directions = new ValueTuple<int, int>[] { (1, 0), (0, -1), (-1, 0), (0, 1) };

            while (rottenQueue.Count > 0)
            {
                var orange = rottenQueue.Dequeue();
                rotten--;
                foreach (var d in directions)
                {
                    int i = orange.R + d.Item1; // row + row shift
                    int j = orange.C + d.Item2; // col + col shift
                    if (i < 0 || i > rows - 1 || j < 0 || j > cols - 1)
                        continue;
                    if (grid[i][j] == 1)
                    {
                        grid[i][j] = 2;
                        fresh--;
                        rottenQueue.Enqueue((i, j));
                        rottenInMinute++;
                    }
                }
                if (rotten == 0 && rottenInMinute > 0)
                {
                    minutes++;
                    rotten = rottenInMinute;
                    rottenInMinute = 0;
                }
            }

            return (fresh == 0) ? minutes : -1;

        }
    }
}