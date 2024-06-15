using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class IntegerToEnglishWords
    {
        public string[] less_than_twenty = {"","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten",
                 "Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen"};

        public string[] by_then = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public string[] thousands = { "", "Thousand", "Million", "Billion" };

        public string NumberToWords(int num)
        {

            if (num == 0) return "Zero";

            var sb = new StringBuilder();
            int idx = 0;

            while (num > 0)
            {
                if (num % 1000 > 0)
                {
                    var sbt = new StringBuilder();
                    helper(sbt, num % 1000);
                    sbt.Append(thousands[idx]).Append(" ");
                    sb.Insert(0, sbt);
                }
                idx++;

                num = num / 1000;
            }

            return sb.ToString().Trim();
        }

        public void helper(StringBuilder sb, int num)
        {

            if (num == 0) return;
            else if (num < 20)
            {
                sb.Append(less_than_twenty[num]).Append(" ");
            }
            else if (num < 100)
            {
                sb.Append(by_then[num / 10]).Append(" ");
                helper(sb, num % 10);
            }
            else
            {
                sb.Append(less_than_twenty[num / 100])
                    .Append(" Hundred ");
                helper(sb, num % 100);
            }
        }
    }
}
/*
 273. Integer to English Words
Hard

Convert a non-negative integer num to its English words representation.

Example 1:

Input: num = 123
Output: "One Hundred Twenty Three"
Example 2:

Input: num = 12345
Output: "Twelve Thousand Three Hundred Forty Five"
Example 3:

Input: num = 1234567
Output: "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"
Example 4:

Input: num = 1234567891
Output: "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One"
 

Constraints:

0 <= num <= 231 - 1
 */