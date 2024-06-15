using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class DetectCapital
    {
        public bool DetectCapitalUse(string word)
        {
            /*
                T=O(n)
                S=O(1)
             */

            int counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if ('Z' - word[i] >= 0)
                    counter++;
            }

            bool valid =
                counter == 0 ||
                counter == word.Length ||
                (counter == 1 && 'Z' - word[0] >= 0);

            return valid;
        }
    }
}
/*
 520. Detect Capital
Easy

We define the usage of capitals in a word to be right when one of the following cases holds:

All letters in this word are capitals, like "USA".
All letters in this word are not capitals, like "leetcode".
Only the first letter in this word is capital, like "Google".
Given a string word, return true if the usage of capitals in it is right.

Example 1:

Input: word = "USA"
Output: true
Example 2:

Input: word = "FlaG"
Output: false
 

Constraints:

1 <= word.length <= 100
word consists of lowercase and uppercase English letters.
 */
