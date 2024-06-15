using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview
{
    /*
     * 49. Group Anagrams
     * Given an array of strings, group anagrams together.

Example:

Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
Output:
[
  ["ate","eat","tea"],
  ["nat","tan"],
  ["bat"]
]
Note:

All inputs will be in lowercase.
The order of your output does not matter.
     */
    class _30_Grouped_Anagrams
    {
        public static IList<IList<string>> Main_30_Grouped_Anagrams(string[] strs) {
            List<List<string>> grouped = new List<List<string>>();
            Dictionary<string, List<string>> ht = new Dictionary<string, List<string>>();

            foreach (var word in strs)
            {
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string sorted = string.Join("", chars);

                if (!ht.ContainsKey(sorted)) {
                    ht.Add(sorted, new List<string>());
                }

                ht[sorted].Add(word);
            }

            return ht.Values.ToList<IList<string>>();
        }
    }
}
