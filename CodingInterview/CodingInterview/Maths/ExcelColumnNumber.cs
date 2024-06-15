using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class ExcelColumnNumber
    {
        public static int TitleToNumber(string columnTitle)
        {
            /*
                T=O(n)
                S=O(1)
             */
            int ans = 0;
            int pow = 1;

            for (int i = columnTitle.Length - 1; i >= 0; i--)
            {
                int val = columnTitle[i] - 64;
                ans = ans + val * pow;
                pow = pow * 26;
            }

            return ans;
        }
    }
}
/*
 171. Excel Sheet Column Number
Easy

Given a string columnTitle that represents the column title as appear in an Excel sheet, return its corresponding column number.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...
 
Example 1:

Input: columnTitle = "A"
Output: 1
Example 2:

Input: columnTitle = "AB"
Output: 28
Example 3:

Input: columnTitle = "ZY"
Output: 701
Example 4:

Input: columnTitle = "FXSHRXW"
Output: 2147483647
 

Constraints:

1 <= columnTitle.length <= 7
columnTitle consists only of uppercase English letters.
columnTitle is in the range ["A", "FXSHRXW"].
 */
