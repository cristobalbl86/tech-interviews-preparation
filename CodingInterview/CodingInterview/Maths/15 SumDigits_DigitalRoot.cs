using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    public class _15_SumDigits_DigitalRoot
    {
        /*
         * Sum of Digits / Digital Root (Code wars)
         * Digital root is the recursive sum of all the digits in a number.

Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. 
This is only applicable to the natural numbers.

Examples
    16  -->  1 + 6 = 7
   942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
         */

        public static int SumDig(string num)
        {
            if (num.Length == 1)
            {
                return Convert.ToInt32(num);
            }
            int result = 0;

            foreach (var n in num)
            {
                result += Convert.ToInt32(n.ToString());
            }

            return SumDig(result.ToString());
        }

        public static void DigitalRoot(long n)
        {
            // Your awesome code here!
            Console.Write(SumDig(n.ToString()));
        }

        
    }
}
