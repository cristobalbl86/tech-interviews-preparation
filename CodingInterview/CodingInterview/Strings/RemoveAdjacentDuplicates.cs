using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class RemoveAdjacentDuplicates
    {
        public static string RemoveDuplicates(string S)
        {
            /*
             * #Stack Approach
             * 
             T=O(n)
            S=O(n) <---by the stack creation
             */
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
            {
                if (st.Count == 0 || st.Peek() != S[i])
                {
                    st.Push(S[i]);
                }
                else
                {
                    st.Pop();
                }
            }

            string ans = string.Empty;
            while (st.Count > 0)
            {
                ans = st.Pop() + ans;
            }

            return ans;
        }

        /*STACK POINTER APPROACH
         * T=O(n)
         * S=O(1)
         * **/
        public static string RemoveDuplicates_StackPointer(string w)
        {
            int sp = -1;
            char[] S = w.ToCharArray();
            
            for (int i = 0; i < S.Length; i++)
            {
                if (sp == -1 || S[sp] != S[i])
                {
                    sp++;
                    S[sp] = S[i];
                }
                else
                {
                    sp--;
                }
            }

            string ans = string.Empty;
            for (int i = 0; i <= sp; i++)
            {
                ans += S[i];
            }

            return ans;
        }
    }
}
/*
 1047. Remove All Adjacent Duplicates In String
Easy

Given a string S of lowercase letters, a duplicate removal consists of choosing two adjacent and equal letters, and removing them.

We repeatedly make duplicate removals on S until we no longer can.

Return the final string after all such duplicate removals have been made.  It is guaranteed the answer is unique.

Example 1:

Input: "abbaca"
Output: "ca"
Explanation: 
For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".
 
Note:
1 <= S.length <= 20000
S consists only of English lowercase letters.*/
