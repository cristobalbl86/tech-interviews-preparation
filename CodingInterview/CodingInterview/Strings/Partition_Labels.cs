using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    class _50_Partition_Labels
    {
        /*
763. Partition Labels

A string S of lowercase English letters is given. We want to partition this string into as many parts as possible so that each letter appears in at most one part, and return a list of integers representing the size of these parts.

Example 1:

Input: S = "ababcbacadefegdehijhklij"
Output: [9,7,8]
Explanation:
The partition is "ababcbaca", "defegde", "hijhklij".
This is a partition so that each letter appears in at most one part.
A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits S into less parts.
 

Note:

S will have length in range [1, 500].
S will consist of lowercase English letters ('a' to 'z') only.         
             */
        public IList<int> PartitionLabels(string S)
        {

            List<int> result = new List<int>();
            if (S == null || S.Length == 0)
                return result;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < S.Length; i++)
            {
                if (dict.ContainsKey(S[i]))
                    dict[S[i]] = i;
                else
                    dict.Add(S[i], i);
            }


            int count = 0;
            int end = -1;

            for (int i = 0; i < S.Length; i++)
            {
                count++;
                char c = S[i];
                end = Math.Max(end, dict[c]);
                if (i == end)
                {
                    result.Add(count);
                    count = 0;
                }
            }

            return result;
        }

        /*KEVIN JR APPROACH
         T= O(2N)
         S= O(1)
         */
        public IList<int> PartitionLabels2(string s)
        {
            var result = new List<int>();
            int[] lastIndexes = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                lastIndexes[s[i] - 'a'] = i;
            }

            int idx = 0;
            while (idx < s.Length)
            {
                int ed = lastIndexes[s[idx] - 'a'];
                int j = idx;

                while (j != ed)
                {
                    ed = Math.Max(ed, lastIndexes[s[j] - 'a']);
                    j++;
                }

                result.Add(ed - idx + 1);
                idx = j + 1;
            }

            return result;
        }
    }
}
