﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class ReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            /*
                T= O(n)
                S= O(n)
             */

            Stack<int> st = new Stack<int>();

            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "/" || tokens[i] == "*")
                {
                    int n1 = st.Pop();
                    int n2 = st.Pop();

                    if (tokens[i] == "+")
                    {
                        st.Push(n2 + n1);
                    }
                    else if (tokens[i] == "-")
                    {
                        st.Push(n2 - n1);
                    }
                    else if (tokens[i] == "/")
                    {
                        st.Push(n2 / n1);
                    }
                    else
                    {
                        st.Push(n2 * n1);
                    }
                }
                else
                {
                    st.Push(Convert.ToInt32(tokens[i]));
                }
            }
            return st.Pop();
        }
    }
}
/*
 150. Evaluate Reverse Polish Notation
Medium

Evaluate the value of an arithmetic expression in Reverse Polish Notation.
Valid operators are +, -, *, and /. Each operand may be an integer or another expression.
Note that division between two integers should truncate toward zero.
It is guaranteed that the given RPN expression is always valid. That means the expression would always evaluate to a result, and there will not be any division by zero operation.

Example 1:

Input: tokens = ["2","1","+","3","*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Example 2:

Input: tokens = ["4","13","5","/","+"]
Output: 6
Explanation: (4 + (13 / 5)) = 6
Example 3:

Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
Output: 22
Explanation: ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
= ((10 * (6 / (12 * -11))) + 17) + 5
= ((10 * (6 / -132)) + 17) + 5
= ((10 * 0) + 17) + 5
= (0 + 17) + 5
= 17 + 5
= 22
 
Constraints:

1 <= tokens.length <= 104
tokens[i] is either an operator: "+", "-", "*", or "/", or an integer in the range [-200, 200].
 */