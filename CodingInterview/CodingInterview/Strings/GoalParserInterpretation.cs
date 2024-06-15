using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CodingInterview.Strings
{
    class GoalParserInterpretation
    {
        /*
         * STACK APPROACH
         * T=O(n)
         * S= O(1)
         */
        public string Interpret(string command)
        {
            if (command == null) return null;

            var ht = new Hashtable();
            ht.Add("G", "G");
            ht.Add("()", "o");
            ht.Add("(al)", "al");

            string res = string.Empty;
            string temp = string.Empty;

            foreach (char c in command)
            {
                temp += c.ToString();
                if (ht.ContainsKey(temp))
                {
                    res += ht[temp];
                    temp = string.Empty;
                }
            }

            return res;
        }

        /*
         ITERATIVE APPROACH
            T= O(n)
            S= O(1)
         */
        public string Interpret_2(string command)
        {
            if (command == null) return null;

            string res = string.Empty;

            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'G')
                {
                    res += "G";
                }
                else if (command[i] == '(' && command[i + 1] == ')')
                {
                    res += "o";
                    i += 1;
                }
                else
                {
                    res += "al";
                    i += 3;
                }
            }

            return res;
        }
    }
}
/*
 1678. Goal Parser Interpretation
Easy

You own a Goal Parser that can interpret a string command. The command consists of an alphabet of "G", "()" and/or "(al)" in some order. The Goal Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" as the string "al". The interpreted strings are then concatenated in the original order.

Given the string command, return the Goal Parser's interpretation of command.

 

Example 1:

Input: command = "G()(al)"
Output: "Goal"
Explanation: The Goal Parser interprets the command as follows:
G -> G
() -> o
(al) -> al
The final concatenated result is "Goal".
Example 2:

Input: command = "G()()()()(al)"
Output: "Gooooal"
Example 3:

Input: command = "(al)G(al)()()G"
Output: "alGalooG"
 

Constraints:

1 <= command.length <= 100
command consists of "G", "()", and/or "(al)" in some order.
 */
