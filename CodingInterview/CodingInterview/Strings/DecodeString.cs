using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class DecodeString
    {
        public string DecodeString_(string s)
        {
            /*MY VERSION - NOT WORKING FOR ALL CASES =(*/
            int n = s.Length;

            var stnum = new Stack<int>();
            var ststr = new Stack<string>();

            string digits = "123456789";

            int st = 0;
            int ed = 0;

            var sb = new StringBuilder();

            int i = 0;
            while (i < n)
            {
                //Console.WriteLine("Loop: " + s[i]);
                if (s[i] == ']')
                {
                    Console.WriteLine("Decoding: " + s[i]);
                    //decode
                    int times = stnum.Pop();
                    string text = ststr.Pop();
                    Console.WriteLine("Times: " + times);
                    Console.WriteLine("text: " + text);
                    for (int k = 0; k < times; k++)
                    {
                        sb.Append(text);
                    }
                }
                else if (digits.IndexOf(s[i]) != -1)
                { //it's a number
                  //Console.WriteLine("Number:" + s[i]);
                    stnum.Push(Convert.ToInt32(s[i] - '0'));
                }
                else if (char.IsLetter(s[i]))
                {
                    //Console.WriteLine("Letter: " + s[i]);
                    int j = i + 1;
                    while (j < n)
                    {
                        if (s[j] != ']' && digits.IndexOf(s[j]) == -1) j++;
                        else break;
                    }

                    ststr.Push(s.Substring(i, j - i));
                    //Console.WriteLine("text: " + s.Substring(i, j-i));
                    i = j;
                    continue;
                }
                i++;
            }
            return sb.ToString();
        }
        public string DecodeString_NickWhite(string s)
        {
            /*
             STACKS APPROACH - NICK WHITE
                T= O(n)
                S= O(n)
             */

            var stnum = new Stack<int>();
            var sttxt = new Stack<string>();

            int idx = 0;
            string temp = "";

            while (idx < s.Length)
            {

                if (char.IsDigit(s[idx]))
                {
                    int count = 0;
                    while (char.IsDigit(s[idx]))
                    {
                        count = count * 10 + (s[idx] - '0');
                        idx++;
                    }

                    stnum.Push(count);
                    idx--; //moving back because while loop ends at next idx
                }
                else if (char.IsLetter(s[idx]))
                {
                    temp += s[idx].ToString();
                }
                else if (s[idx] == '[')
                {
                    sttxt.Push(temp);
                    temp = "";
                }
                else if (s[idx] == ']')
                {
                    var sb = new StringBuilder(sttxt.Pop());

                    int times = stnum.Pop();
                    //string text = sttxt.Pop();

                    for (int i = 1; i <= times; i++)
                    {
                        sb.Append(temp);
                    }

                    temp = sb.ToString();
                }

                idx++;
            }

            return temp;
        }
    }
}

/*
 394. Decode String
Medium

Given an encoded string, return its decoded string.

The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times. Note that k is guaranteed to be a positive integer.

You may assume that the input string is always valid; No extra white spaces, square brackets are well-formed, etc.

Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k. For example, there won't be input like 3a or 2[4].

Example 1:

Input: s = "3[a]2[bc]"
Output: "aaabcbc"
Example 2:

Input: s = "3[a2[c]]"
Output: "accaccacc"
Example 3:

Input: s = "2[abc]3[cd]ef"
Output: "abcabccdcdcdef"
Example 4:

Input: s = "abc3[cd]xyz"
Output: "abccdcdcdxyz"
 

Constraints:

1 <= s.length <= 30
s consists of lowercase English letters, digits, and square brackets '[]'.
s is guaranteed to be a valid input.
All the integers in s are in the range [1, 300].
 */