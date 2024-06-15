using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class First_Unique_Char_String
    {
        /**
         HASH MAP APPROACH
            T= O(n)
            S= O(1)
         */
        public int FirstUniqChar(string s)
        {
            var ht = new Hashtable();

            for (int i = 0; i < s.Length; i++)
            {
                if (ht.ContainsKey(s[i]))
                {
                    ht[s[i]] = (int)ht[s[i]] + 1;
                }
                else
                {
                    ht.Add(s[i], 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if ((int)ht[s[i]] == 1)
                    return i;
            }

            return -1;
        }

        /*
         * ARRAY ALPHABET APPROACH
         * T= O(n)
         * S= O(1)
         */
        public int FirstUniqChar_(string s)
        {

            int[] freq = new int[26]; //alphabet

            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (freq[s[i] - 'a'] == 1)
                    return i;
            }

            return -1;
        }
    }
}
