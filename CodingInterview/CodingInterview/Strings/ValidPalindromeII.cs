using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class ValidPalindromeII
    {
        public static bool ValidPalindrome (string s){
            return Check(s, 0);
        }
        public static bool Check(string s, int times)
        {
            if (times > 1)
                return false;

            string str = s;

            int st = 0;
            int ed = s.Length - 1;

            while (st < ed)
            {

                if (s[st] != s[ed])
                {
                    return Check(s.Remove(st, 1), times + 1) ||
                    Check(s.Remove(ed, 1), times + 1);
                }
                else
                {
                    st++;
                    ed--;
                }
            }

            return true;
        }

        //Approach #2, Udemy Ankit, helper function
        public bool ValidPalindrome2(string s)
        {
            /*
             T= O(n)
            S= O(1)
             */
            int st = 0;
            int ed = s.Length - 1;

            while (st < ed)
            {
                if (s[st] != s[ed])
                {
                    if (check2(s, st + 1, ed)
                       || check2(s, st, ed - 1))
                    {
                        return true;
                    }
                    else
                        return false;
                }
                st++;
                ed--;
            }
            return true;
        }

        public bool check2(string w, int s, int e)
        {
            while (s < e)
            {
                if (w[s] != w[e]) return false;
                s++;
                e--;
            }
            return true;
        }
    }
}

/*
 Runtime: 92 ms, faster than 83.93% of C# online submissions for Valid Palindrome II.
Memory Usage: 43.9 MB, less than 8.66% of C# online submissions for Valid Palindrome II.

680. Valid Palindrome II
Easy

Share
Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome.

Example 1:
Input: "aba"
Output: True
Example 2:
Input: "abca"
Output: True
Explanation: You could delete the character 'c'.
Note:
The string will only contain lowercase characters a-z. The maximum length of the string is 50000.
 */
