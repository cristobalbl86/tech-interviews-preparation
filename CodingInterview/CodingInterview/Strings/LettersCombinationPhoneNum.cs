using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CodingInterview.Strings
{
    class LettersCombinationPhoneNum
    {
        /*
            T= O(m+n)
            S= O(m+n)
         */
        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();

            if (digits == null || digits.Length == 0) return result;

            var ht = new Hashtable();
            ht.Add('0', "");
            ht.Add('1', "");
            ht.Add('2', "abc");
            ht.Add('3', "def");
            ht.Add('4', "ghi");
            ht.Add('5', "jkl");
            ht.Add('6', "mno");
            ht.Add('7', "pqrs");
            ht.Add('8', "tuv");
            ht.Add('9', "wxyz");

            checkCombinations(digits, 0, "", ht, result);

            return result;
        }

        public void checkCombinations(string digits, int index, string current, Hashtable ht, List<string> result)
        {
            if (index == digits.Length)
            {
                result.Add(current);
                return;
            }

            string letters = ht[digits[index]].ToString();
            foreach (char c in letters)
            {
                checkCombinations(digits, index + 1, current + c, ht, result);
            }
        }
    }
}
/*
 17. Letter Combinations of a Phone Number
Medium

Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

Example 1:

Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
Example 2:

Input: digits = ""
Output: []
Example 3:

Input: digits = "2"
Output: ["a","b","c"]
 

Constraints:

0 <= digits.length <= 4
digits[i] is a digit in the range ['2', '9'].
 */
