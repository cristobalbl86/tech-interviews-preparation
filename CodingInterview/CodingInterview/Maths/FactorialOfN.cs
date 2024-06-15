using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class FactorialOfN
    {
        /*
         T=O(n)
         S=O(n)
         */
        public static int MainFact(int n) {
            return Fact(n); 
        }
        public static int Fact(int n) {
            if (n < 0) return -1;
            if (n == 0) return 1;

            int smallAns = Fact(n - 1);

            return n * smallAns;
        }
    }
}
