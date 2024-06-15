using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class ArrayStringAreEquals
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            //Approach #1, using in-built method
            /*
                T= O(1)
                S=O(1)
             */

            //return string.Join("", word1) == string.Join("", word2);

            //Approach #2, creating helper method
            /*
                T= O(n+m)
                S= O(n+m)
             */
            return strJoin(word1) == strJoin(word2);
        }

        //helper method
        public string strJoin(string[] s)
        {
            string res = string.Empty;

            foreach (string w in s)
            {
                res += w;
            }

            return res;
        }
    }
}
/*
 1662. Check If Two String Arrays are Equivalent
Easy

Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.

A string is represented by an array if the array elements concatenated in order forms the string.

 

Example 1:

Input: word1 = ["ab", "c"], word2 = ["a", "bc"]
Output: true
Explanation:
word1 represents string "ab" + "c" -> "abc"
word2 represents string "a" + "bc" -> "abc"
The strings are the same, so return true.
Example 2:

Input: word1 = ["a", "cb"], word2 = ["ab", "c"]
Output: false
Example 3:

Input: word1  = ["abc", "d", "defg"], word2 = ["abcddefg"]
Output: true
 

Constraints:

1 <= word1.length, word2.length <= 103
1 <= word1[i].length, word2[i].length <= 103
1 <= sum(word1[i].length), sum(word2[i].length) <= 103
word1[i] and word2[i] consist of lowercase letters.
 */
