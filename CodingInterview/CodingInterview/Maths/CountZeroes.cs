using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class CountZeroes
    {
        /*
            T= O(n)
            S= O(n)
         */
        public static int Zeroes(int n) {
            //base case
            if (n == 0) return 0;

            //recursion case
            int sa = Zeroes(n / 10);

            //calculation
            int last = n % 10;

            if (last == 0) return sa + 1;

            return sa;
        }
    }
}
