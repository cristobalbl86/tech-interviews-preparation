using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class Longest_Palindromic_Substring
    {
        public string LongestPalindrome(string s)
        {
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {

                string res1 = IsPalindrome(s, i, i);
                string res2 = IsPalindrome(s, i, i + 1);

                if (res1.Length > res2.Length && res1.Length > result.Length)
                    result = res1;
                else if (res2.Length > res1.Length && res2.Length > result.Length)
                    result = res2;
            }

            return result;
        }

        public string IsPalindrome(string s, int st, int ed)
        {

            if (s == null || st > ed) return null;

            while (st >= 0 && ed < s.Length && s[st] == s[ed])
            {
                st--;
                ed++;
            }

            return s.Substring(st + 1, ed - st - 1);

        }
    }
}
/*
 5. Longest Palindromic Substring
Medium

Given a string s, return the longest palindromic substring in s.

 

Example 1:

Input: s = "babad"
Output: "bab"
Note: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"
Example 3:

Input: s = "a"
Output: "a"
Example 4:

Input: s = "ac"
Output: "a"
 

Constraints:

1 <= s.length <= 1000
s consist of only digits and English letters (lower-case and/or upper-case),
 */