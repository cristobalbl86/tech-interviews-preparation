using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class ReverseOnlyLetters
    {
        public string ReverseOnlyLetters_(string S)
        {
            /*
                T= O(n)
                S= O(n)
             */
            if (S.Length <= 2) return S;

            int st = 0;
            int ed = S.Length - 1;
            char[] res = S.ToCharArray();


            while (st < ed)
            {

                while (st < ed && !char.IsLetter(res[st])) st++;
                while (st < ed && !char.IsLetter(res[ed])) ed--;

                char c = res[st];
                res[st] = res[ed];
                res[ed] = c;

                st++;
                ed--;
            }

            return new string(res);
        }
    }
}
/*
 917. Reverse Only Letters
Easy
Given a string S, return the "reversed" string where all characters that are not a letter stay in the same place, and all letters reverse their positions.

Example 1:

Input: "ab-cd"
Output: "dc-ba"
Example 2:

Input: "a-bC-dEf-ghIj"
Output: "j-Ih-gfE-dCba"
Example 3:

Input: "Test1ng-Leet=code-Q!"
Output: "Qedo1ct-eeLg=ntse-T!"
 

Note:

S.length <= 100
33 <= S[i].ASCIIcode <= 122 
S doesn't contain \ or "
 */
