using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Microsoft
{
    class MaxLengthStringUniqueChar
    {
        //VER#1
        //Failed some leetcode cases
        public int MaxLength(IList<string> arr)
        {
            if (arr == null)
            {
                return 0;
            }

            int current = 0;
            int max = 0;

            for (int x = 0; x < arr.Count; x++)
            {
                current = arr[x].Length;

                for (int y = x + 1; y < arr.Count; y++)
                {
                    string word = arr[x] + arr[y];
                    if (CheckString(word))
                        current = word.Length;

                    if (current > max)
                    {
                        max = current;
                        current = 0;
                    }
                }
            }

            if (current > max)
                return current;

            return max;
        }

        public bool CheckString(string s)
        {

            HashSet<char> hs = new HashSet<char>();

            foreach (char c in s)
            {

                if (hs.Contains(c))
                    return false;
                else
                    hs.Add(c);
            }

            return true;
        }

        //VER#2, after watching Kevin explanation
        public int MaxLength2(IList<string> arr)
        {
            if (arr == null)
            {
                return 0;
            }

            int[] result = new int[1];

            ValidateArray2(arr, 0, "", result);

            return result[0];
        }

        public void ValidateArray2(IList<string> arr, int index, string s, int[] result)
        {
            if (CheckString2(s) > result[0])
            {
                result[0] = s.Length;
                //return;
            }

            if (index == arr.Count)
            {
                return;
            }

            ValidateArray2(arr, index + 1, s, result);
            ValidateArray2(arr, index + 1, s + arr[index], result);
        }

        public int CheckString2(string s)
        {

            HashSet<char> hs = new HashSet<char>();

            foreach (char c in s)
            {

                if (hs.Contains(c))
                    return -1;
                else
                    hs.Add(c);
            }

            return s.Length;
        }
    }

    public class BestSolution
    {
        /*
         T= O(2n) 
         S= O(n)
         */
        public int MaxLength(IList<string> arr)
        {

            if (arr == null) return 0;

            int[] result = new int[1];

            validateString(arr, "", 0, result);

            return result[0];
        }

        public void validateString(IList<string> arr, string current, int index, int[] result)
        {

            //base case
            int count = uniqueChars(current);
            if (count == -1)
                return;

            if (arr.Count == index && count > result[0])
            {
                result[0] = count; //current.Length;
                return;
            }

            if (arr.Count == index)
                return;

            validateString(arr, current, index + 1, result);
            validateString(arr, current + arr[index], index + 1, result);
        }

        public int uniqueChars(string str)
        {

            int[] alp = new int[26];

            foreach (char c in str)
            {

                if (alp[c - 'a'] > 0)
                    return -1;
                else
                    alp[c - 'a']++;
            }

            return str.Length;
        }
    }
}
/*
 1239. Maximum Length of a Concatenated String with Unique Characters
Medium

Given an array of strings arr. String s is a concatenation of a sub-sequence of arr which have unique characters.

Return the maximum possible length of s.

 

Example 1:

Input: arr = ["un","iq","ue"]
Output: 4
Explanation: All possible concatenations are "","un","iq","ue","uniq" and "ique".
Maximum length is 4.
Example 2:

Input: arr = ["cha","r","act","ers"]
Output: 6
Explanation: Possible solutions are "chaers" and "acters".
Example 3:

Input: arr = ["abcdefghijklmnopqrstuvwxyz"]
Output: 26
 

Constraints:

1 <= arr.length <= 16
1 <= arr[i].length <= 26
arr[i] contains only lower case English letters.
 */