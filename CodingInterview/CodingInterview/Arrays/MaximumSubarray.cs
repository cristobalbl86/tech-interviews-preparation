using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class MaximumSubarray
    {
        /*
            T= O(n)
            S= O(1)
         */
        public int MaxSubArray_Nick(int[] nums)
        {
            //MICHAEL M
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = Math.Max(nums[i], nums[i] + nums[i - 1]);
                max = Math.Max(nums[i], max);
            }
            return max;
        }

        public int MaxSubArray_Michael(int[] nums)
        {
            //NICK WHITE
            int max = nums[0];
            int cur_max = max;

            for (int i = 1; i < nums.Length; i++)
            {
                cur_max = Math.Max(nums[i] + cur_max, nums[i]);
                max = Math.Max(cur_max, max);
            }

            return max;
        }
    }
}
/*
 * 53. Maximum Subarray
Easy
Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

Example 1:

Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
Example 2:

Input: nums = [1]
Output: 1
Example 3:

Input: nums = [5,4,-1,7,8]
Output: 23
 

Constraints:

1 <= nums.length <= 3 * 104
-105 <= nums[i] <= 105
 

Follow up: If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
 */
