using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class FirstMissingPositive
    {
        //MY APPROACH ***********************************************************************
        /*
            T= O(n)
            S= O(1)
         */
        public int FirstMissingPositive_(int[] nums)
        {
            int result = 0;
            int max = 0;

            for (int x = 1; x <= nums.Length; x++)
            {
                result = findnum(nums, 0, x);
                if (result == -1) //if not found, return X number
                    return x;
                if (x > max) //in case that no missing num, to return max+1
                    max = x;
            }

            return (result != -1) ? max + 1 : result;
        }
        public int findnum(int[] nums, int index, int target)
        {
            //last element and not found
            if (index == nums.Length - 1 && nums[index] != target)
                return -1;

            //last element or found
            if (index == nums.Length - 1 || nums[index] == target)
                return target;

            int sa = findnum(nums, index + 1, target);

            if (sa != target) return -1;

            return target;
        }

        //RACHIT JAIN APPROACH ***********************************************************
        public int FirstMissingPositive_Rajit(int[] nums)
        {
            /*
                T= O(n)
                S= O(1)
             */
            if (nums == null || nums.Length == 0) return 1;

            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                int correctPos = nums[i] - 1;

                while (nums[i] >= 1 && nums[i] <= n &&
                     nums[i] != nums[correctPos])
                {
                    int temp = nums[i];
                    nums[i] = nums[correctPos];
                    nums[correctPos] = temp;

                    correctPos = nums[i] - 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] != i + 1)
                    return i + 1;
            }

            return n + 1;
        }
    }
}

/*
 41. First Missing Positive
Hard

Given an unsorted integer array nums, find the smallest missing positive integer.

Example 1:

Input: nums = [1,2,0]
Output: 3
Example 2:

Input: nums = [3,4,-1,1]
Output: 2
Example 3:

Input: nums = [7,8,9,11,12]
Output: 1

Constraints:

1 <= nums.length <= 300
-231 <= nums[i] <= 231 - 1
 */
