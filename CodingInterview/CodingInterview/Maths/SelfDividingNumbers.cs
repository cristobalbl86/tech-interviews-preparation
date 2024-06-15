using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class SelfDividingNumbers
    {
        public IList<int> SelfDividingNumbers_(int left, int right)
        {
            /*
                T= O(n)
                S= O(n)
            */

            var result = new List<int>();

            for (int i = left; i <= right; i++)
            {
                if (isSelfDividing(i))
                    result.Add(i);
            }

            return result;
        }

        public bool isSelfDividing(int num)
        {
            int temp = num;

            while (temp > 0)
            {
                int lastdigit = temp % 10;
                if (lastdigit == 0 || num % lastdigit != 0)
                    return false;

                temp = temp / 10;
            }

            return true;
        }
    }
}
/*
 728. Self Dividing Numbers
Easy

A self-dividing number is a number that is divisible by every digit it contains.

For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.
A self-dividing number is not allowed to contain the digit zero.

Given two integers left and right, return a list of all the self-dividing numbers in the range [left, right].

 

Example 1:

Input: left = 1, right = 22
Output: [1,2,3,4,5,6,7,8,9,11,12,15,22]
Example 2:

Input: left = 47, right = 85
Output: [48,55,66,77]
 

Constraints:

1 <= left <= right <= 104
 */