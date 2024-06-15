using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class VerifyingAnAlienDictionary
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            /*
                T = O(n2 * m)
                S = O(1)
             */
            int[] alp = new int[26];

            //set char order into alp array
            for (int i = 0; i < order.Length; i++)
            {
                alp[order[i] - 'a'] = i;
            }

            for (int w1 = 0; w1 < words.Length; w1++)
            {
                for (int w2 = w1 + 1; w2 < words.Length; w2++)
                {
                    int min = Math.Min(words[w1].Length, words[w2].Length);

                    for (int k = 0; k < min; k++)
                    {
                        int c1 = alp[words[w1][k] - 'a'];
                        int c2 = alp[words[w2][k] - 'a'];

                        //w1 < w2 -> break -> to compare next word
                        if (c1 < c2) break;
                        //w2 < w1 -> return false
                        else if (c2 < c1) return false;
                        //all chars are equal and we are at last char... then need to compare words length
                        else if (k == min - 1 && words[w1].Length > words[w2].Length) return false;
                    }
                }
            }

            return true;
        }
    }
}

/*
 953. Verifying an Alien Dictionary
Easy

In an alien language, surprisingly they also use english lowercase letters, but possibly in a different order. The order of the alphabet is some permutation of lowercase letters.

Given a sequence of words written in the alien language, and the order of the alphabet, return true if and only if the given words are sorted lexicographicaly in this alien language.

Example 1:

Input: words = ["hello","leetcode"], order = "hlabcdefgijkmnopqrstuvwxyz"
Output: true
Explanation: As 'h' comes before 'l' in this language, then the sequence is sorted.
Example 2:

Input: words = ["word","world","row"], order = "worldabcefghijkmnpqstuvxyz"
Output: false
Explanation: As 'd' comes after 'l' in this language, then words[0] > words[1], hence the sequence is unsorted.
Example 3:

Input: words = ["apple","app"], order = "abcdefghijklmnopqrstuvwxyz"
Output: false
Explanation: The first three characters "app" match, and the second string is shorter (in size.) According to lexicographical rules "apple" > "app", because 'l' > '∅', where '∅' is defined as the blank character which is less than any other character (More info).
 

Constraints:

1 <= words.length <= 100
1 <= words[i].length <= 20
order.length == 26
All characters in words[i] and order are English lowercase letters.
 */