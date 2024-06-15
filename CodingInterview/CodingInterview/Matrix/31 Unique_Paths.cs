using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    class _31_Unique_Paths
    {
        public static int Main_31_Unique_Paths(int m, int n) {
            int[,] matrix = new int[m, n];

            //1s to the first column
            for (int x = 0; x < m; x++)
            {
                matrix[x, 0] = 1;
            }

            //1s to the first row
            for (int x = 0; x < n; x++)
            {
                matrix[0, x] = 1;
            }

            //check pending cells and sum(left + top)
            for (int row = 1; row < m; row++)
            {
                for (int col = 1; col < n; col++)
                {
                    matrix[row, col] = matrix[row, col - 1] + matrix[row - 1, col];
                }
            }

            //return right-bottom cell
            return matrix[m - 1, n - 1];
        }
    }
}
