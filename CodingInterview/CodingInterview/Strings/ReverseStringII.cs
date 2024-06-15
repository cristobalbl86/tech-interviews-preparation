using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    /*
541. Reverse String II
Easy

Given a string and an integer k, you need to reverse the first k characters for every 2k characters counting from the start of the string. If there are less than k characters left, reverse all of them. If there are less than 2k but greater than or equal to k characters, then reverse the first k characters and left the other as original.
Example:
Input: s = "abcdefg", k = 2
Output: "bacdfeg"
Restrictions:
The string consists of lower English letters only.
Length of the given string and k will in the range [1, 10000]     
     */
    class ReverseStringII
    {
        public static string ReverseStr(string s, int k)
        {
            char[] str = s.ToCharArray();

            for (int x = 0; x < s.Length; x += k * 2)
            {
                int last = (x + k) - 1;

                if (last >= s.Length)
                    last = s.Length - 1;

                Swap(x, last, str);
            }

            return String.Join("", str);
        }

        public static void Swap(int start, int end, char[] str)
        {
            while (start < end)
            {
                char temp = str[start];
                str[start++] = str[end];
                str[end--] = temp;
            }
        }
    }
}
