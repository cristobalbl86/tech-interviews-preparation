using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class GeometricSum
    {
        public static double GeoSum(int k) {
            //base
            if (k == 0) return 1;
            //recursion
            double sa = GeoSum(k - 1);
            //calculation
            return sa + 1.0 / Math.Pow(2, k);
        }
    }
}
