using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingInterview.Microsoft
{
    class ItemInfo
    {
        public string number { get; set; }
        public int index { get; set; }
        public int final { get; set; }
        public ItemInfo(string number, int index, int final)
        {
            this.number = number;
            this.index = index;
            this.final = final;
        }
    }
    public class _01_Remove_K_Get_Smallest
    {
        public static string Main_01_Remove_K_Get_Smallest(int k, int Number) {
            //if (string.IsNullOrEmpty(num))
            //    return "";
            //if (num == "0")
            //    return num;

            //if (num.Length == k)
            //    return "0";
            //if (k < 1)
            //    return num;

            int idx = 0;
            List<ItemInfo> items = new List<ItemInfo>();
            string newnum = Number.ToString();
            foreach (var item in Number.ToString().ToArray())
            {
                items.Add(
                    new ItemInfo(item.ToString(), idx, Convert.ToInt32(Number.ToString().Remove(idx, 1))));
                idx++;
            }

            var ordereditems = items.OrderBy(i => i.final).Select(i => i.index);

            int removed = 0;
            foreach (var item in ordereditems)
            {
                newnum = newnum.Remove(item - removed, 1);
                removed++;
                if (removed == k)
                    break;
            }

            if (string.IsNullOrEmpty(newnum))
                newnum = "0";

            return newnum;
            Console.WriteLine($"{Number} : {newnum}");
        }

        public static string RemoveKdigits(string num, int k)
        {
            string strresult = String.Empty;
            if (num.Length == k) return "0";
            if (k < 1) return num;

            Stack<int> stack = new Stack<int>();
            int removed = 0;

            foreach (char c in num)
            {
                int current = Convert.ToInt32(c.ToString());
                while (stack.Count > 0 && stack.Peek() > current && removed < k)
                {
                    stack.Pop();
                    removed++;
                }

                stack.Push(current);
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
