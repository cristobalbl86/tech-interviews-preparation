using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class NumberOfDigits
    {
        public static int count(int n) 
        {
            /*
                T= O(n)
                S= O(n)
            */

            //base case
            if (n == 0) return 0;

            //recursion  case
            int ans = count(n / 10);
            
            //calculation
            return ans + 1;
        }
    }
}
