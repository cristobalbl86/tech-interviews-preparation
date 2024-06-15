using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class ConsecutiveNumbersSum
    {
        //MY OWN APPROACH - BRUTE FORCE - DID NOT WORK FOR ALL CASES =(
        public int ConsecutiveNumbersSum1(int n)
        {

            int sum = 0;
            int result = 0;
            int j = 0;

            for (int i = 0; i <= n; i++)
            {

                if (i == n)
                {
                    sum = 0;
                    result++;
                }
                else
                    sum += i;

                if (sum > n)
                {
                    j++; // = i - 1;
                    sum = sum - j; //i + j;
                }

                if (sum == n)
                {
                    //sum = 0;
                    result++;
                    //j = i;
                    j++;
                    sum = sum - j;

                }
            }

            return result;
        }

        //BEST WAY
        public int ConsecutiveNumbersSum2(int n)
        {

            int count = 0;
            int i = 1;

            while (n > 0)
            {

                n = n - i;
                if (n % i == 0) count++;
                i++;

            }


            return count;
        }
    }
}
/*
 * 829. Consecutive Numbers Sum
Hard

Given a positive integer n, how many ways can we write it as a sum of consecutive positive integers?

Example 1:

Input: n = 5
Output: 2
Explanation: 5 = 5 = 2 + 3
Example 2:

Input: n = 9
Output: 3
Explanation: 9 = 9 = 4 + 5 = 2 + 3 + 4
Example 3:

Input: n = 15
Output: 4
Explanation: 15 = 15 = 8 + 7 = 4 + 5 + 6 = 1 + 2 + 3 + 4 + 5
Note: 1 <= n <= 10 ^ 9.
 */