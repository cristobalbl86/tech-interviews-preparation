using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Sorting
{
    class SelectionSort
    {
        public static int[] SelectionSort_(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int idxMin = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[idxMin])
                    {
                        idxMin = j;
                    }
                }

                if (idxMin != i)
                {
                    int temp = nums[idxMin];
                    nums[idxMin] = nums[i];
                    nums[i] = temp;
                }
            }
            return nums;
        }
    }
}
