using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class RemoveAdjacentDuplicatesII
    {
        public string RemoveDuplicates(string s, int k)
        {
            /*
             T=O(n)
             S=O(n)
             */
            var st = new Stack<(char letter, int count)>();

            for (int i = 0; i < s.Length; i++)
            {
                if (st.Count == 0 || s[i] != st.Peek().letter)
                {
                    st.Push((s[i], 1));
                }
                else
                {
                    var peek = st.Peek();

                    st.Pop(); //because stack does not allow to edit values, must be pop and then push updated
                    if (peek.count < k - 1)
                    {
                        st.Push((peek.letter, peek.count + 1));
                    }
                }
            }

            string ans = string.Empty;
            while (st.Count > 0)
            {
                var pop = st.Pop();
                for (int j = 0; j < pop.count; j++)
                {
                    ans = pop.letter + ans;
                }
            }

            return ans;
        }
    }
}
/*
 1209. Remove All Adjacent Duplicates in String II
Medium

Given a string s, a k duplicate removal consists of choosing k adjacent and equal letters from s and removing them causing the left and the right side of the deleted substring to concatenate together.

We repeatedly make k duplicate removals on s until we no longer can.

Return the final string after all such duplicate removals have been made.

It is guaranteed that the answer is unique.

Example 1:

Input: s = "abcd", k = 2
Output: "abcd"
Explanation: There's nothing to delete.
Example 2:

Input: s = "deeedbbcccbdaa", k = 3
Output: "aa"
Explanation: 
First delete "eee" and "ccc", get "ddbbbdaa"
Then delete "bbb", get "dddaa"
Finally delete "ddd", get "aa"
Example 3:

Input: s = "pbbcggttciiippooaais", k = 2
Output: "ps"
 
Constraints:

1 <= s.length <= 10^5
2 <= k <= 10^4
s only contains lower case English letters.
 */
