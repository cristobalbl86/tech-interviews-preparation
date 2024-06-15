using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Sorting
{
    class BubbleSort
    {
        //O(n^2)
        public static int[] BubbleSort_(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }
    }
}
