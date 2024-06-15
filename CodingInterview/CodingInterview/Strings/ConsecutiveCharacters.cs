using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class ConsecutiveCharacters
    {
        public int MaxPower(string s)
        {

            if (s.Length <= 1) //for strings shorter or equal than 1
                return s.Length;

            int max = 0;
            int counter = 0;
            char? prev = null;

            foreach (char c in s)
            {
                if (c == prev)
                    counter++;
                else if (counter > max)
                {
                    max = counter;
                    counter = 1;
                }
                else
                    counter = 1;

                prev = c;
            }

            if (counter > max) //check the last letter ocurrence against the current max
                return counter;

            return max;
        }
    }
}
/*
 1446. Consecutive Characters
Easy
Given a string s, the power of the string is the maximum length of a non-empty substring that contains only one unique character.

Return the power of the string.

Example 1:

Input: s = "leetcode"
Output: 2
Explanation: The substring "ee" is of length 2 with the character 'e' only.
Example 2:

Input: s = "abbcccddddeeeeedcba"
Output: 5
Explanation: The substring "eeeee" is of length 5 with the character 'e' only.
Example 3:

Input: s = "triplepillooooow"
Output: 5
Example 4:

Input: s = "hooraaaaaaaaaaay"
Output: 11
Example 5:

Input: s = "tourist"
Output: 1
 

Constraints:

1 <= s.length <= 500
s contains only lowercase English letters.
 */
