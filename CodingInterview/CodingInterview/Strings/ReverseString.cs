using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    /*
344. Reverse String
Easy

Write a function that reverses a string. The input string is given as an array of characters char[].
Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
You may assume all the characters consist of printable ascii characters.

Example 1:
Input: ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]

Example 2:
Input: ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]     
     */
    class ReverseString
    {
        public static void ReverseString_Main(char[] s) {
            //approach #1
            //T= O(n)
            //S= O(1)

            //384 ms, faster than 64.98%
            //34.8 MB, less than 42.92%
            int f = 0;
            int b = s.Length - 1;

            while (f < b)
            {
                char temp = s[f];
                s[f] = s[b];
                s[b] = temp;

                f++;
                b--;
            }

            //approach #2
            //392 ms, faster than 39.49% 
            //35 MB, less than 10.38%
            string w = String.Join("", s);
            int idx = s.Length - 1;
            foreach (char c in w)
            {
                s[idx] = c;
                idx--;
            }

            //approach #3 stack
            //T= O(n)
            //S= O(n)
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                st.Push(s[i]);
            }

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = st.Pop();
            }

        }
    }
}
