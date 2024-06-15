using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            /*
                T= O(n)
                S= O(1)
             */
            //HASH TABLE APPROACH - NOT SO GOOD 'CAUSE THE ARRAY IS SORTED
            var ht = new Hashtable();
            int[] result = null;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!ht.ContainsKey(numbers[i]))
                    ht.Add(numbers[i], i + 1);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int balance = target - numbers[i];

                if (ht.ContainsKey(balance) && i + 1 != (int)ht[balance])
                {
                    result = new int[] { i + 1, (int)ht[balance] };
                    Array.Sort(result);
                    return result;
                }
            }

            return null;
        }

        //POINTERS APPROACH
        public int[] TwoSum_(int[] numbers, int target)
        {
            /*
                T=O(n)
                S=O(1)
             */
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    return new int[] { left + 1, right + 1 };
                }

                if (numbers[left] + numbers[right] < target)
                    left++;
                else
                    right--;

            }

            return new int[] { left + 1, right + 1 };

        }
    }
}

/*
 167. Two Sum II - Input array is sorted
Easy

Given an array of integers numbers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.

Return the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers.length.

You may assume that each input would have exactly one solution and you may not use the same element twice.

Example 1:

Input: numbers = [2,7,11,15], target = 9
Output: [1,2]
Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
Example 2:

Input: numbers = [2,3,4], target = 6
Output: [1,3]
Example 3:

Input: numbers = [-1,0], target = -1
Output: [1,2]
 
Constraints:
2 <= numbers.length <= 3 * 104
-1000 <= numbers[i] <= 1000
numbers is sorted in increasing order.
-1000 <= target <= 1000
Only one valid answer exists.
 */
