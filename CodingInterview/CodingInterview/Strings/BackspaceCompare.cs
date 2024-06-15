using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class BackspaceCompare
    {
        /*
         * STACK approach
         * T= O(n+m) | n^2
         * S= O(n);
         * **/
        public static bool BackspaceCompare_(string S, string T)
        {
            return checkstr(S) == checkstr(T);
        }
        public static string checkstr(string s)
        {
            var st = new Stack<char>();

            foreach (char c in s)
            {
                if (c != '#')
                    st.Push(c);
                else if (st.Count > 0)
                    st.Pop();
            }

            string res = string.Empty;

            while (st.Count > 0)
            {
                res = st.Pop() + res;
            }

            return res;
        }

        /*
         BACKWARD ITERATION
            T= O(m+n)
            S= O(1)
         */
        public bool BackspaceCompare_2(string S, string T)
        {
            int backs = 0;
            string w1 = string.Empty;
            string w2 = string.Empty;

            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == '#')
                {
                    backs++;
                    continue;
                }

                if (backs == 0)
                {
                    w1 = S[i] + w1;
                }
                else
                    backs--;
            }

            backs = 0;
            for (int i = T.Length - 1; i >= 0; i--)
            {
                if (T[i] == '#')
                {
                    backs++;
                    continue;
                }

                if (backs == 0)
                {
                    w2 = T[i] + w2;
                }
                else
                    backs--;
            }

            return w1 == w2;
        }
    }
}
/*
 * 844. Backspace String Compare
Easy

Given two strings S and T, return if they are equal when both are typed into empty text editors. # means a backspace character.

Note that after backspacing an empty text, the text will continue empty.

Example 1:

Input: S = "ab#c", T = "ad#c"
Output: true
Explanation: Both S and T become "ac".
Example 2:

Input: S = "ab##", T = "c#d#"
Output: true
Explanation: Both S and T become "".
Example 3:

Input: S = "a##c", T = "#a#c"
Output: true
Explanation: Both S and T become "c".
Example 4:

Input: S = "a#c", T = "b"
Output: false
Explanation: S becomes "c" while T becomes "b".
Note:

1 <= S.length <= 200
1 <= T.length <= 200
S and T only contain lowercase letters and '#' characters.
Follow up:

Can you solve it in O(N) time and O(1) space?
 * **/
