using CodingInterview.Sorting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Microsoft
{
    class RemoveDuplicates_UnsortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int duplicated = 0;
            int prev = int.MinValue;

            nums = SelectionSort.SelectionSort_(nums);

            for (int x = 0; x < nums.Length; x++)
            {
                if (prev == nums[x])
                {
                    duplicated++;

                    //move rest of items 1 position left
                    for (int j = x; j < nums.Length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    //move repeated num to the end
                    nums[nums.Length - duplicated] = prev;

                    prev = nums[x];
                }
                else
                    prev = nums[x];
            }

            return nums.Length - duplicated;
        }

    }
}
