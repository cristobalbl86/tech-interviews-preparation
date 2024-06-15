using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview
{
    class _04_Lowest_And_Higher
    {
        public static void Main04_Lowest_And_Higher(string numbers) {

            //Solution #1
            int[] numarr = numbers.Split(" ").Select(n => Convert.ToInt32(n)).OrderByDescending(n => n).ToArray();

            Console.WriteLine( $"{numarr[0].ToString()}, {numarr[numarr.Length - 1].ToString()}");
        }

    }
}
