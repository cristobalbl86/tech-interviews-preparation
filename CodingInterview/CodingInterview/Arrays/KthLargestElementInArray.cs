using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview.Arrays
{
    class KthLargestElementInArray
    {
        /*
         MY SOLUTION - 
            T= O(n)
            S= O(1)
         */
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int count = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (count == k)
                    return nums[i];

                count++;
            }

            return -1;
        }

        /*
         * LINQ SOLUTION
         */
        public int FindKthLargest2(int[] nums, int k)
        {
            return nums.OrderByDescending(n => n).ElementAt(k - 1);
        }

        /*
         MY SOLUTION IMPROVED
         */
        public int FindKthLargest3(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
        /*
         SORTED LIST - NOT working when repeated elements
         */
        public int FindKthLargest4(int[] nums, int k)
        {
            SortedList<int, int> sl = new SortedList<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                sl.Add(nums[i], i);
            }

            for (int j = 0; j < sl.Count; j++)
            {
                if (j + 1 == nums.Length - (k - 1))
                    return sl.Keys[j];
            }

            return -1;
        }
    }
}
