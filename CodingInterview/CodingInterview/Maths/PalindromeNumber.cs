using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class PalindromeNumber
    {
        /**
         * T= O(n)
         * S= O(1)
         */
        public bool IsPalindrome(int x)
        {

            //Number is negative OR ends with 0
            if (x < 0 || (x > 0 && x % 10 == 0)) return false;

            int reversed = 0;

            while (x > reversed)
            {
                //reversed= reversed * 10 + last digit of X
                reversed = reversed * 10 + x % 10;

                //remove last digit from X
                x = x / 10;
            }

            //both equals OR number in the middle removed from reversed (Ex: 1(2)1, 34(5)43)
            return x == reversed || x == reversed / 10;
        }
    }
}
/*
 9. Palindrome Number

Easy
Given an integer x, return true if x is palindrome integer.

An integer is a palindrome when it reads the same backward as forward. For example, 121 is palindrome while 123 is not.

Example 1:

Input: x = 121
Output: true
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
Example 4:

Input: x = -101
Output: false

Constraints:

-231 <= x <= 231 - 1

Follow up: Could you solve it without converting the integer to a string?
 */
