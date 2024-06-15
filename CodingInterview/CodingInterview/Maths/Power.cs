using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class Power
    {
        public static int Pow(int x, int n) {
            if (n == 0) return 1;

            int ans = Pow(x, n - 1);

            return x * ans;
        }
    }
}
