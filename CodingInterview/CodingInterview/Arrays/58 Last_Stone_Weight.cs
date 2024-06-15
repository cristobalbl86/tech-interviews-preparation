using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingInterview
{
    class _58_Last_Stone_Weight
    {
        /*
1046. Last Stone Weight
Easy
We have a collection of stones, each stone has a positive integer weight.

Each turn, we choose the two heaviest stones and smash them together.  Suppose the stones have weights x and y with x <= y.  The result of this smash is:

If x == y, both stones are totally destroyed;
If x != y, the stone of weight x is totally destroyed, and the stone of weight y has new weight y-x.
At the end, there is at most 1 stone left.  Return the weight of this stone (or 0 if there are no stones left.)

Example 1:

Input: [2,7,4,1,8,1]
Output: 1
Explanation: 
We combine 7 and 8 to get 1 so the array converts to [2,4,1,1,1] then,
we combine 2 and 4 to get 2 so the array converts to [2,1,1,1] then,
we combine 2 and 1 to get 1 so the array converts to [1,1,1] then,
we combine 1 and 1 to get 0 so the array converts to [1] then that's the value of last stone.
 
Note:
1 <= stones.length <= 30
1 <= stones[i] <= 1000         
             */

        public static int LastStoneWeight(int[] stones)
        {

            List<int> l = new List<int>();

            foreach (int s in stones.OrderByDescending(v => v))
            {
                l.Add(s);
            }

            while (l.Count > 1)
            {
                l = l.OrderByDescending(v => v).ToList();
                int stone1 = l[0];
                int stone2 = l[1];

                l.RemoveAt(0);
                l.RemoveAt(0);

                if (stone1 != stone2)
                    l.Add(stone1 - stone2);
            }

            return l.Count == 1 ? l[0] : 0;
        }
    }
}
