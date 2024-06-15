using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;

namespace CodingInterview
{
    class _03_Unique_String_Characters
    {
        public static void Main_03_Unique_String_Characters(string a, string b) {

            ////Solution #1
            string result = string.Empty;

            //foreach(var s in a.ToLower()) {
            //    if (b.ToLower().IndexOf(s) == -1)
            //        result += s;
            //}

            //foreach (var s in b.ToLower()) {
            //    if (a.ToLower().IndexOf(s) == -1)
            //        result += s;
            //}

            //Solution #2
            var checkstr = (a + b).ToLower().ToArray()
                .Select(c => c.ToString())
                .Where(c=> !a.ToLower().Contains(c) || !b.ToLower().Contains(c));

            result = string.Join("", checkstr); 

            Console.WriteLine(result);
        }
    }
}
