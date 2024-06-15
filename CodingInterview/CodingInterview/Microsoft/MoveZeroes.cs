using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Microsoft
{
    class MoveZeroes
    {
        public static void mainMoveZeroes(int[] nums)
        {
            int count = 0;
            int temp = 0;
            for (int x = 0; x < nums.Length; x++)
            {
                if (nums[x] != 0)
                {
                    temp = nums[x];
                    nums[x] = nums[count];
                    nums[count] = temp;
                    count++;
                }
            }
        }
    }
}
/*
 283. Move Zeroes
Easy

Share
Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Example:

Input: [0,1,0,3,12]
Output: [1,3,12,0,0]
Note:

You must do this in-place without making a copy of the array.
Minimize the total number of operations.
 */
