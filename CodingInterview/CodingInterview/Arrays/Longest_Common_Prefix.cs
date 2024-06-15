using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class Longest_Common_Prefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            /*
             S= O(m) //var result changes after every loop
            T= O(mn) //two nested loops for different collections
             */
            string result = "";

            if (strs.Length == 0) return result;

            for (int i = 0; i < strs[0].Length; i++) //m
            {
                for (int j = 1; j < strs.Length; j++) //n
                {
                    if (i >= strs[j].Length || strs[0][i] != strs[j][i])
                    {
                        return result;
                    }
                }
                result += strs[0][i];
            }

            return result;
        }
    }
}
/*
 14. Longest Common Prefix
Easy

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 
Constraints:

0 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lower-case English letters.
 */
