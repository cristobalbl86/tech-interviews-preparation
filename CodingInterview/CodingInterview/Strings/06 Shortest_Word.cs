using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview
{
    class _06_Shortest_Word
    {
        public static void Main06_Shortest_Word(string words) {

            //Solution #1
            //var shortest = words.Split(" ").ToArray().Select(w => w.Length).Min();

            //Solution #2 - Iterative
            string strShortest = string.Empty;
            foreach (string w in words.Split(" ")) {
                if (string.IsNullOrEmpty(strShortest))
                    strShortest = w;
                if (w.Length < strShortest.Length) {
                    strShortest = w;
                }
            }

            Console.WriteLine(strShortest.Length);
        }
    }
}
