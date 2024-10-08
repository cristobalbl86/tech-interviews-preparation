﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            /*
             * Nick White approach, 3 arrrays
             * T= O(n)
             * S= O(2n)
             */
            int n = nums.Length;

            int[] result = new int[n];
            int[] lefts = new int[n];
            int[] rights = new int[n];

            lefts[0] = 1;
            rights[n - 1] = 1;

            for (int i = 0; i < n - 1; i++)
            {
                lefts[i + 1] = nums[i] * lefts[i];
            }

            for (int j = n - 1; j > 0; j--)
            {
                rights[j - 1] = nums[j] * rights[j];
            }

            for (int k = 0; k < n; k++)
            {
                result[k] = lefts[k] * rights[k];
            }

            return result;
        }

        /*
         NICK WHITE - BEST APPROACH - InLine
            T= O(n)
            S= O(1)
         */
        public int[] ProductExceptSelf2(int[] nums)
        {

            
        }
    }
}

/*
 238. Product of Array Except Self
Medium

Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.


Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
 

Constraints:

2 <= nums.length <= 105
-30 <= nums[i] <= 30
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 

Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)
 */