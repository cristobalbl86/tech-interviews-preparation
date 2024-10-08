﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class DecodeWays
    {
        public class MyTry
        {
            /*Incorrect not working for all cases*/
            public int NumDecodings(string s)
            {
                if (s.Length == 1 && s != "0") return 1;
                if (s.Length == 2 && s[0] != 0) return 2;

                int limit = 26;
                int ways = 1;

                for (int i = 1; i < s.Length; i++)
                {
                    Console.WriteLine(s.Substring(i, 1));
                    Console.WriteLine(s.Substring(i - 1, 2));

                    int oneDigit = Convert.ToInt32(s.Substring(i, 1));
                    int twoDigit = Convert.ToInt32(s.Substring(i - 1, 2));
                    if (oneDigit > 0 && oneDigit < 10) ways++;
                    if (twoDigit > 10 && twoDigit < limit) ways++;
                }

                return ways;
            }
        }

        public class Solution
        {
            /*
                T= O(n)
                S= O(n)
             */
            public int NumDecodings(string s)
            {

                int[] ways = new int[s.Length + 1];

                ways[0] = 1;
                ways[1] = s[0] == '0' ? 0 : 1;

                for (int i = 2; i <= s.Length; i++)
                {

                    int oneD = Convert.ToInt32(s.Substring(i - 1, 1));
                    int twoD = Convert.ToInt32(s.Substring(i - 2, 2));

                    if (oneD >= 1)
                        ways[i] += ways[i - 1];

                    if (twoD >= 10 && twoD <= 26)
                        ways[i] += ways[i - 2];
                }

                return ways[s.Length];
            }
        }
    }
}
/*
 91. Decode Ways
Medium

A message containing letters from A-Z can be encoded into numbers using the following mapping:

'A' -> "1"
'B' -> "2"
...
'Z' -> "26"
To decode an encoded message, all the digits must be grouped then mapped back into letters using the reverse of the mapping above (there may be multiple ways). For example, "11106" can be mapped into:

"AAJF" with the grouping (1 1 10 6)
"KJF" with the grouping (11 10 6)
Note that the grouping (1 11 06) is invalid because "06" cannot be mapped into 'F' since "6" is different from "06".

Given a string s containing only digits, return the number of ways to decode it.

The answer is guaranteed to fit in a 32-bit integer.

 

Example 1:

Input: s = "12"
Output: 2
Explanation: "12" could be decoded as "AB" (1 2) or "L" (12).
Example 2:

Input: s = "226"
Output: 3
Explanation: "226" could be decoded as "BZ" (2 26), "VF" (22 6), or "BBF" (2 2 6).
Example 3:

Input: s = "0"
Output: 0
Explanation: There is no character that is mapped to a number starting with 0.
The only valid mappings with 0 are 'J' -> "10" and 'T' -> "20", neither of which start with 0.
Hence, there are no valid ways to decode this since all digits need to be mapped.
Example 4:

Input: s = "06"
Output: 0
Explanation: "06" cannot be mapped to "F" because of the leading zero ("6" is different from "06").
 

Constraints:

1 <= s.length <= 100
s contains only digits and may contain leading zero(s).
 */
