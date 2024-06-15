using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class LengthOfLastWord
    {
        public static int LengthOfLastWordMain(string s)
        {
            //T= O(n)
            //S = O(1)
            int counter = 0;
            int n = s.Length;
            int i = 0;

            while (i < n)
            {
                if (s[i] != ' ')
                {
                    counter++;
                    i++;
                }
                else
                {
                    while (i < n && s[i] == ' ') i++;

                    if (i == n)
                        return counter;
                    else
                    {
                        counter = 0;
                    }
                }
            }

            return counter;
        }

        public int LengthOfLastWord_2ndApproach(string s)
        {
            //reading from the end of the string
            int counter = 0;
            int n = s.Length;
            int i = n - 1;

            while (i >= 0)
            {
                if (s[i] != ' ')
                {
                    counter++;
                    i--;
                }
                else
                {
                    if (counter > 0)
                        return counter;

                    while (i >= 0 && s[i] == ' ') i--;

                    if (i == -1)
                        return counter;
                    else
                        counter = 0;
                }
            }

            return counter;
        }
    }
}

/*
 58. Length of Last Word
Easy

Given a string s consists of some words separated by spaces, return the length of the last word in the string. If the last word does not exist, return 0.
A word is a maximal substring consisting of non-space characters only.

Example 1:

Input: s = "Hello World"
Output: 5
Example 2:

Input: s = " "
Output: 0
 
Constraints:

1 <= s.length <= 104
s consists of only English letters and spaces ' '.
 */
