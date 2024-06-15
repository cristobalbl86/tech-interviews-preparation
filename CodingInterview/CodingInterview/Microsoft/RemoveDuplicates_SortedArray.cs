using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Microsoft
{
    class RemoveDuplicates_SortedArray
    {
        public static int RemoveDuplicates(int[] nums) {
            if (nums == null || nums.Length == 0)
                return 0;

            int duplicated = 0;
            int? prev = null;

            for(int x = 0; x < nums.Length; x++)
            {
                if (prev == nums[x])
                {
                    duplicated++;
                }
                
                nums[x - duplicated] = nums[x];
                prev = nums[x];
            }

            return nums.Length - duplicated;
        }

       
    }
}

/*
 * 
 * Runtime: 236 ms, faster than 98.37% of C# online submissions for Remove Duplicates from Sorted Array.
Memory Usage: 34.2 MB, less than 33.88% of C# online submissions for Remove Duplicates from Sorted Array.
 * 
 * 
 * 
 * 
 26. Remove Duplicates from Sorted Array
Easy

Share
Given a sorted array nums, remove the duplicates in-place such that each element appears only once and returns the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

Example 1:

Given nums = [1,1,2],

Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.

It doesn't matter what you leave beyond the returned length.
Example 2:

Given nums = [0,0,1,1,1,2,2,3,3,4],

Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.
 */
