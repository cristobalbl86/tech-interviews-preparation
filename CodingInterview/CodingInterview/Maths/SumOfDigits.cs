using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class SumOfDigits
    {
        public static int SumDigits(int n) {
            //base case
            if (n == 0) return 0;

            //recursion
            int ans = SumDigits(n / 10);
            
            //calculation
            int lastdigit = n % 10;
            return ans + lastdigit;
        }
    }
}
