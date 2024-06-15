using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    /*
     557. Reverse Words in a String III
Easy

Share
Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

Example 1:
Input: "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"
Note: In the string, each word is separated by single space and there will not be any extra space in the string.
     */
    class ReverseStringIII
    {
        public static string ReverseString3(string s) {
            List<string> result = new List<string>();

            foreach (string word in s.Split(' '))
            {
                char[] wordarray = word.ToCharArray();
                reverse(wordarray);
                result.Add(String.Join("", wordarray));
            }

            return String.Join(" ", result);
        }

        public static void reverse(char[] word)
        {
            int st = 0;
            int ed = word.Length - 1;

            while (st < ed)
            {
                char temp = word[st];
                word[st] = word[ed];
                word[ed] = temp;

                st++;
                ed--;
            }
        }
    }
}
