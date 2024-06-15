using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class ReverserInteger
    {
        public int Reverse(int x)
        {
            /*
                T=O(1)
                S=O(n) ?
             */

            string num = x.ToString();
            bool isNegative = false;
            if (num.Substring(0, 1) == "-")
            {
                isNegative = true;
                num = num.Substring(1);
            }

            char[] numc = num.ToCharArray();
            Array.Reverse(numc);

            long res = Convert.ToInt64(new string(numc));

            if (int.MaxValue < res)
                return 0;

            return isNegative ? -1 * Convert.ToInt32(res) : Convert.ToInt32(res);

        }

        public int Reverse2(int x)
        {
            /*
             T = O(n)
             S = O(1)
             */

            long result = 0;

            while (x != 0)
            {
                result = (result * 10) + (x % 10);
                x = x / 10;
            }

            if (result > int.MaxValue || result < int.MinValue) return 0;

            return (int)result;
        }
    }
}
/*
 7. Reverse Integer
Easy

Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

Example 1:

Input: x = 123
Output: 321
Example 2:

Input: x = -123
Output: -321
Example 3:

Input: x = 120
Output: 21
Example 4:

Input: x = 0
Output: 0
 

Constraints:

-231 <= x <= 231 - 1
 */