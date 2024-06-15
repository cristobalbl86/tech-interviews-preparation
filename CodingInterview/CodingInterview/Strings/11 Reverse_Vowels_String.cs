using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class _11_Reverse_Vowels_String
    {
        public class Solution
        {
            public string ReverseVowels(string s)
            {
                if (s == null || s.Length == 0) return s;

                var chars = s.ToCharArray();
                int start = 0;
                int end = chars.Length - 1;
                string vowels = "aeiouAEIOU";

                while (start < end)
                {
                    if (vowels.IndexOf(chars[start]) == -1)
                    {
                        start++;
                    }
                    else if (vowels.IndexOf(chars[end]) == -1)
                    {
                        end--;
                    }
                    else
                    {
                        var temp = chars[start];
                        chars[start] = chars[end];
                        chars[end] = temp;
                        start++;
                        end--;
                    }
                }

                return new string(chars);
            }
        }
    }
}
