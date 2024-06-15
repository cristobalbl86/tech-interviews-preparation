using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    /*
     * 20 - Valid_Parentheses
     Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Note that an empty string is also considered valid.

Example 1:

Input: "()"
Output: true
Example 2:

Input: "()[]{}"
Output: true
Example 3:

Input: "(]"
Output: false
Example 4:

Input: "([)]"
Output: false
Example 5:

Input: "{[]}"
Output: true
         */
    class _33_Valid_Parentheses
    {
        public static bool IsValid(string s) {

            /*
            string[] valids = { "()","{}","[]"};
            string schecked = s; // string.Empty;

            while (schecked.Length > 0) {
                if(!check(ref schecked, valids))
                    return false;
            }

            return true;
        }
        public static bool check(ref string s, string[] valids) {
            bool anymatch = false;
            foreach (string rule in valids) {
                if (s.Contains(rule)) {
                    s.Remove(s.IndexOf(rule), 2);
                    anymatch = true;
                }
            }
            return anymatch;
            */

            Dictionary<string, string> dict = new Dictionary<string, string>();
            Stack<string> mystack = new Stack<string>();

            dict.Add(")","(");
            dict.Add("]", "[");
            dict.Add("}", "{");

            foreach (char c in s) {
                if (dict.ContainsKey(c.ToString()))
                {
                    if (mystack.Count > 0 && dict[c.ToString()] == mystack.Peek())
                    {
                        mystack.Pop();
                    }
                    else {
                        return false;
                    }
                }
                else {
                    mystack.Push(c.ToString());
                }
            }

            return mystack.Count == 0;
        }
    }
}
