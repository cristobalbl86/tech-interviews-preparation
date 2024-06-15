using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class ThousandSeparator
    {
        /*
            T=O(n)
            S= O(1) ? O(n)?
         */
        public string ThousandSeparator_(int n)
        {
            string num = n.ToString();

            //base cases
            if (num.Length <= 3) return num;

            string res = string.Empty;
            int count = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (count == 3)
                {
                    res = "." + res;
                    count = 0;
                }
                res = num[i] + res;

                count++;
            }

            return res;
        }
    }
}
/*
 1556. Thousand Separator
Easy

Given an integer n, add a dot (".") as the thousands separator and return it in string format.

Example 1:

Input: n = 987
Output: "987"
Example 2:

Input: n = 1234
Output: "1.234"
Example 3:

Input: n = 123456789
Output: "123.456.789"
Example 4:

Input: n = 0
Output: "0"
 

Constraints:

0 <= n < 2^31
 */
