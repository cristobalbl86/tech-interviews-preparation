using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class Multiplication
    {
        /*
            T= O(n)
            S= O(n)
         */
        public static int Multiply(int m, int n) {
            //base case
            if (n == 0) return 0;

            //recursion
            int ans = Multiply(m, n - 1);

            //calculation
            return ans + m;
        }
    }
}
