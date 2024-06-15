using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class TwoSum
    {
        //BRUTE FORCE APPROACH
        /*
            T=O(n^2)
            S=O(1)
         */
        public int[] TwoSum_BruteForce(int[] nums, int target)
        {
            int[] result = new int[] { -1, -1 };

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }

                }
            }

            return null;
        }

        /*
         HASH MAP APPROACH
            T= O(n)
            S= O(n)
         */
        public int[] TwoSum_(int[] nums, int target)
        {
            int[] result = new int[] { -1, -1 };
            var ht = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!ht.ContainsKey(nums[i]))
                    ht.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int rest = target - nums[i];
                if (ht.ContainsKey(rest) && i != (int)ht[rest])
                {
                    result[0] = i;
                    result[1] = (int)ht[rest];

                    return result;
                }
            }

            return null;
        }
    }
}
