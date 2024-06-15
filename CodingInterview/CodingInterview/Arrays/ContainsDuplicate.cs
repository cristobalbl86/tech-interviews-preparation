using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class ContainsDuplicate
    {
        /**
            T= O(n)
            S= O(n)
         */
        public bool ContainsDuplicate_(int[] nums)
        {
            var hs = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hs.Contains(nums[i]))
                    return true;
                else
                    hs.Add(nums[i]);
            }

            return false;
        }
    }
}
/*
 217. Contains Duplicate
Easy

Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

Example 1:

Input: nums = [1,2,3,1]
Output: true
Example 2:

Input: nums = [1,2,3,4]
Output: false
Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
 

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
 */
