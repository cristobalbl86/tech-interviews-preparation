using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    public class _3Sum
    {
        //solved using 3 pointers approach
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                //prevent duplicates in case that my current index "i" equals to previous
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        List<int> tmp = new List<int>();
                        tmp.Add(nums[i]);
                        tmp.Add(nums[left]);
                        tmp.Add(nums[right]);
                        result.Add(tmp);

                        left++;
                        right--;

                        //prevent duplicates in case that my next left & right have the same values
                        while (left < right && nums[left] == nums[left - 1])
                        {
                            left++;
                        }
                        while (left < right && nums[right] == nums[right + 1])
                        {
                            right--;
                        }
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result.ToArray();
        }
    }
}


/*
15. 3Sum
Medium
Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

Notice that the solution set must not contain duplicate triplets.
Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Example 2:

Input: nums = []
Output: []
Example 3:

Input: nums = [0]
Output: []
*/
