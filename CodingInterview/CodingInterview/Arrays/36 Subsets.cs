using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview
{
    /*
     * 78. Subsets
     Given a set of distinct integers, nums, return all possible subsets (the power set).

Note: The solution set must not contain duplicate subsets.

Example:

Input: nums = [1,2,3]
Output:
[
  [3],
  [1],
  [2],
  [1,2,3],
  [1,3],
  [2,3],
  [1,2],
  []
]
         */
    class _36_Subsets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>());

            foreach (var num in nums)
            {
                int currentCount = result.Count;
                for (int i = 0; i < currentCount; i++)
                {
                    List<int> subset = result[i].ToList<int>(); //create a copy of list [i]
                    subset.Add(num);
                    result.Add(subset);
                }
            }

            return result;
        }
    }
}
