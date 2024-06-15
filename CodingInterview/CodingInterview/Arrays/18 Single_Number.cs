using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingInterview
{
    class _18_Single_Number
    {
        /*
         Runtime: 104 ms, faster than 68.35% of C# online submissions for Single Number.
        Memory Usage: 27.4 MB, less than 27.94% of C# online submissions for Single Number.
             */
        public static int SingleNumber(int[] nums) {
            HashSet<int> hs = new HashSet<int>();

            foreach (var num in nums)
            {
                if (hs.Contains(num))
                {
                    hs.Remove(num);
                }
                else
                {
                    hs.Add(num);
                }
            }

            return hs.Select(n => n).FirstOrDefault();

        }
    }
}
