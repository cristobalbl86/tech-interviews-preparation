using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingInterview
{
    class _51_Reorganize_String
    {
        /*
767. Reorganize String
Medium

Given a string S, check if the letters can be rearranged so that two characters that are adjacent to each other are not the same.

If possible, output any possible result.  If not possible, return the empty string.

Example 1:

Input: S = "aab"
Output: "aba"
Example 2:

Input: S = "aaab"
Output: ""
Note:

S will consist of lowercase letters and have length in range [1, 500].         
             */

        public static string ReorganizeString(string S)
        {
            var max = S.GroupBy(p => p)
                        .Select(p => (val: p.Key, count: p.Count()))
                        .OrderBy(p => p.count).ToArray();

            if (max[max.Length - 1].count > (S.Length + 1) / 2) return string.Empty;

            var res = new char[S.Length];
            var t = 1;
            foreach (var (c, count) in max)
            {
                for (var i = 0; i < count; i++)
                {
                    if (t >= S.Length) t = 0;
                    res[t] = c;
                    t += 2;
                }
            }

            return new string(res);
        }
    }
}
