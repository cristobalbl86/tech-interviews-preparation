using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Microsoft
{
    class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2)
                return n;

            int ways = 2;
            int prevways = 1;
            int stairnum = 3;

            while (stairnum <= n)
            {
                int newprev = ways;
                ways += prevways;
                prevways = newprev;

                stairnum++;
            }

            return ways;
        }

        //slower
        public int ClimbStairsFib(int n)
        {
            int[] ways = new int[n + 1];
            ways[0] = 1;
            ways[1] = 1;
            for (int x = 2; x < ways.Length; x++)
            {
                ways[x] = ways[x - 1] + ways[x - 2];
            }

            return ways[n];
        }
    }
}
/*
 Runtime: 36 ms, faster than 92.91% of C# online submissions for Climbing Stairs.
Memory Usage: 15.1 MB, less than 69.16% of C# online submissions for Climbing Stairs.

70. Climbing Stairs
Easy

You are climbing a stair case. It takes n steps to reach to the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

Example 1:

Input: 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:

Input: 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step
 */
