using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingInterview
{
    class _45_Missing_Num
    {
        public class Solution
        {
            public static int MissingNumber(int[] nums)
            {

                if (nums == null)
                    return 0;

                int idx = 0;
                //Array.Sort(nums);
                foreach (var item in nums.OrderBy(n => n).Select(n => n).ToArray())
                {
                    if (item != idx)
                    {
                        return idx;
                    }
                    idx++;
                }

                //completed loop without missing nums, return the next one
                return nums.Length;
               

            }
            public int MissingNumber_Gaussian(int[] nums)
            {
                //GAUSSIAN FORMULA APPROACH
                //T= O(n)
                //S= O(1)

                int expected = nums.Length * (nums.Length + 1) /2;
                int sum = 0;

                for(int x =0; x < nums.Length; x++){
                    sum += nums[x];
                }

                return expected - sum;

            }

            public int MissingNumber_iterate(int[] nums)
            {
                //CHECKING INDEXES
                //T= O(n)
                //S= O(1)

                Array.Sort(nums);
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != nums[i])
                        return i;
                }
                return nums.Length;
            }
        }
    }
}
/*
 268. Missing Number
Easy

Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.

Follow up: Could you implement a solution using only O(1) extra space complexity and O(n) runtime complexity?

Example 1:

Input: nums = [3,0,1]
Output: 2
Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.
Example 2:

Input: nums = [0,1]
Output: 2
Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.
Example 3:

Input: nums = [9,6,4,2,3,5,7,0,1]
Output: 8
Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.
Example 4:

Input: nums = [0]
Output: 1
Explanation: n = 1 since there is 1 number, so all numbers are in the range [0,1]. 1 is the missing number in the range since it does not appear in nums.
 

Constraints:

n == nums.length
1 <= n <= 104
0 <= nums[i] <= n
All the numbers of nums are unique.
 */
