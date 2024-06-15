using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Microsoft
{
    public class RemoveKDigits
    {
        public static string RemoveKdigits(string num, int k)
        {
            string strresult = string.Empty;
            if (num.Length == k) return "0";
            if (k < 1) return num;

            Stack<int> stack = new Stack<int>();
            int removed = 0;
            //int idx = 0;

            foreach (char c in num)
            {
                int current = Convert.ToInt32(c.ToString());
                while (stack.Count > 0 && stack.Peek() > current && removed < k)
                {
                    stack.Pop();
                    removed++;
                }

                stack.Push(current);
                //idx++;
            }

            while (removed < k)
            {
                stack.Pop();
                removed++;
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            char[] result = sb.ToString().ToCharArray();
            Array.Reverse(result);

            if (result.Length > 1)
            {
                strresult = new string(result).TrimStart('0');
            }
            else
                strresult = new string(result);

            return String.IsNullOrEmpty(strresult) ? "0" : strresult;
        }
    }
}
