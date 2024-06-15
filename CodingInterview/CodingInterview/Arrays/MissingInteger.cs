using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingInterview.Arrays
{
    class MissingInteger
    {
        //detected time complexity: O(N**2)
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int search = 1;

            int[] positives = A.Select(n => n).Where(n => n > 0).ToArray();

            while (true)
            {
                if (positives.Where(n => n == search).Select(n => n).Count() == 0)
                {
                    return search;
                }
                search++;
            }

        }
    }
}
