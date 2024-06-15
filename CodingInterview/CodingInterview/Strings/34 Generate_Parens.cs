using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    /*
     * 22. Generate Parentheses
     Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

For example, given n = 3, a solution set is:
[
  "((()))",
  "(()())",
  "(())()",
  "()(())",
  "()()()"
]
         */
    class _34_Generate_Parens
    {
        public static List<string> result = new List<string>();
        public static IList<string> GenerateParenthesis(int n)
        {
            generate("", 0, 0, n);
            return result;
        }

        public static void generate(string s, int open, int close, int max)
        {
            if (open + close == max * 2)
            {
                result.Add(s);
                return;
            }
            if (open < max)
                generate(s + "(", open + 1, close, max);
            if (close < open)
                generate(s + ")", open, close + 1, max);

            "asdsdf".Split();
        }
    }
}
