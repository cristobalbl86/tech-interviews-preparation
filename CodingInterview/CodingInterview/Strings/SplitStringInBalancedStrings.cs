using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class SplitStringInBalancedStrings
    {
        public int BalancedStringSplit(string s)
        {
            /*
            --fastern than 26.18%, 92ms, memory 22mb
            Dictionary<char,int> dict = new Dictionary<char, int>();
            int count = 0;

            foreach(char c in s){
                if(dict.ContainsKey(c)){
                    dict[c]++;
                }else{
                    dict.Add(c, 1);
                }

                if(dict.ContainsKey('R') && dict.ContainsKey('L') && dict['R'] == dict['L'])
                   count++;
            }

            return count;
            */

            /*
            int countL = 0;
            int countR = 0;
            int count = 0;

            foreach(char c in s){
                if(c == 'R')
                    countR++;
                else
                    countL++;

                if(countL == countR)
                    count++;
            }

            return count;
            */

            /*
                T= O(n)
                S= O(1)
            */
            int count = 0;
            int balance = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R') balance++;
                else balance--;

                if (balance == 0) count++;
            }

            return count;
        }
    }
}
/*
 1221. Split a String in Balanced Strings
Easy

Balanced strings are those that have an equal quantity of 'L' and 'R' characters.

Given a balanced string s, split it in the maximum amount of balanced strings.

Return the maximum amount of split balanced strings.

Example 1:

Input: s = "RLRRLLRLRL"
Output: 4
Explanation: s can be split into "RL", "RRLL", "RL", "RL", each substring contains same number of 'L' and 'R'.
Example 2:

Input: s = "RLLLLRRRLR"
Output: 3
Explanation: s can be split into "RL", "LLLRRR", "LR", each substring contains same number of 'L' and 'R'.
Example 3:

Input: s = "LLLLRRRR"
Output: 1
Explanation: s can be split into "LLLLRRRR".
Example 4:

Input: s = "RLRRRLLRLL"
Output: 2
Explanation: s can be split into "RL", "RRRLLRLL", since each substring contains an equal number of 'L' and 'R'
 

Constraints:

1 <= s.length <= 1000
s[i] is either 'L' or 'R'.
s is a balanced string.
 */
