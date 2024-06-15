using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview.Arrays
{
    class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            /*
             T=  O(n)
             S = O(n)
             */
            int[][] sorted = intervals.OrderBy(a => a[0]).ToArray();

            var current = sorted[0];
            var result = new List<int[]>();

            result.Add(current);

            for (int i = 0; i < sorted.Length; i++)
            {
                int[] interval = sorted[i];

                if (interval[0] <= current[1])
                {
                    current[1] = Math.Max(interval[1], current[1]);
                }
                else
                {
                    current = interval;
                    result.Add(current);
                }

            }

            return result.ToArray();
        }
    }
}
/*
 56. Merge Intervals
Medium

Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
Example 2:

Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
 

Constraints:

1 <= intervals.length <= 104
intervals[i].length == 2
0 <= starti <= endi <= 104
 */
