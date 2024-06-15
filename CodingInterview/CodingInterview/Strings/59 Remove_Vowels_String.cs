using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    class _59_Remove_Vowels_String
    {
        public static string removeVowels(string s) {
            HashSet<char> vowels = new HashSet<char>();
            vowels.Add('a');
            vowels.Add('e');
            vowels.Add('i');
            vowels.Add('o');
            vowels.Add('u');

            StringBuilder sb = new StringBuilder();
            foreach(var c in s.ToCharArray()) {
                if (!vowels.Contains(c)) {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
