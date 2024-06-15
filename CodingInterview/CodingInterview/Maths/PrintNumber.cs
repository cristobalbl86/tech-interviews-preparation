using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class PrintNumber
    {
        /*
         T= O(n)
        S= O(n)
         */
        public static void PrintN(int n) {
            if (n == 0) return;

            PrintN(n - 1);

            Console.WriteLine(n);

            return;
        }
    }
}
/*
 Print(5)
1
2
3
4
5
 */