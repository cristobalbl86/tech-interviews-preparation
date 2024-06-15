using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class ReverseVowels
    {
        public static void Main(string word) {
            word = word.ToLower();
            char[] result = word.ToCharArray();

            int st = 0;
            int ed = word.Length - 1;

            while (st < ed)
            {

                if (!IsVowel(result[st]))
                    st++;
                if (!IsVowel(result[ed]))
                    ed--;

                if (IsVowel(result[st]) && IsVowel(result[ed]))
                {
                    char temp = result[st];
                    result[st] = result[ed];
                    result[ed] = temp;

                    st++;
                    ed--;
                }

            }

            Console.WriteLine(String.Join("", result));
        }

        public static bool IsVowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                return true;
            else
                return false;
        }
    }
}
