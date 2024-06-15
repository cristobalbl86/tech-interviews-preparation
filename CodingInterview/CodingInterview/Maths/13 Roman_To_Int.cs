using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    class _13_Roman_To_Int
    {
        public static int RomanToInt(string s)
        {

            Hashtable ht = new Hashtable();
            ht.Add("I", 1);
            ht.Add("V", 5);
            ht.Add("X", 10);
            ht.Add("L", 50);
            ht.Add("C", 100);
            ht.Add("D", 500);
            ht.Add("M", 1000);

            int totalInt = 0;

            for (int x = 0; x < s.Length; x++)
            {
                int currentInt = (int)ht[s[x].ToString()];
                int nextInt = (x + 1 == s.Length) ?
                    0 : (int)ht[s[x + 1].ToString()]; //check if X index has reached string. length

                if (nextInt > 0)
                {
                    if (currentInt >= nextInt)
                        totalInt += currentInt;
                    else
                    {
                        totalInt += (nextInt - currentInt);
                        x++; //skip next idx in loop because is considered now
                    }
                }
                else
                {
                    totalInt += currentInt;
                }
            }

            return totalInt;
        }
    }
}
