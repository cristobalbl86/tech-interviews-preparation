using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class SingleElementInSortedArray
    {
        public int SingleNonDuplicate(int[] nums)
        {
            /*
                T=O(n)
                S=O(1)
             */
            
            int counter = 1;
            if (nums.Length == 1) return nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    counter++;
                }
                else if (counter == 1) //single
                { 
                    return nums[i - 1];
                }
                else
                {
                    counter = 1;
                }
            }

            if (counter == 1) return nums[nums.Length - 1];

            return 0;
        }

        //Binary Search approach
        public int SingleNonDuplicate_2(int[] nums)
        {
            /*
                T= O(LogN)
                S= O(1)
             */
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                bool isEven = (right - mid) % 2 == 0;

                if (nums[mid] == nums[mid - 1])
                {
                    if (isEven)
                    {
                        right = mid - 2;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else if (nums[mid] == nums[mid + 1])
                {
                    if (isEven)
                    {
                        left = mid + 2;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    return nums[mid];
                }
            }
            return nums[left];
        }
    }
}
/*
540. Single Element in a Sorted Array
Medium

You are given a sorted array consisting of only integers where every element appears exactly twice, except for one element which appears exactly once.Find this single element that appears only once.

Follow up: Your solution should run in O(log n) time and O(1) space.

Example 1:

Input: nums = [1,1,2,3,3,4,4,8,8]
Output: 2
Example 2:

Input: nums = [3,3,7,7,10,11,11]
Output: 10
 

Constraints:

1 <= nums.length <= 10^5
0 <= nums[i] <= 10^5
*/