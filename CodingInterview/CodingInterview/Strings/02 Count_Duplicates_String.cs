using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodingInterview
{
    class _02_Count_Duplicates_String
    {
        public static void Main_02_Count_Duplicates_String(string str) {

            //Solution #1
            var groupl = str.ToLower().ToArray().GroupBy(l => l)
                .Select(l => new {
                    Letter = l.Key,
                    Counter = l.Count()
                })
                .Where(l => l.Counter > 1).Count();

            Console.WriteLine("Letters repeated: " + groupl.ToString());


            //Solution #2
            int repeated = 0;
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            foreach(char s in str.ToLower()) {
                if (ht[s] == null)
                {
                    ht.Add(s, 1);
                }
                else {
                    ht[s] = (int)ht[s] + 1;
                    if ((int)ht[s] == 2)
                        repeated++;
                }
            }
            Console.WriteLine("Letters repeated: " + repeated.ToString());
        }
    }
}
