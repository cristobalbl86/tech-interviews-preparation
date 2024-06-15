using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Maths
{
    class FizzBuzz
    {
        public static IList<string> GetFizzBuzz(int n)
        {
            //T= O(n)
            //S= O(1) <--because is requesting to return a List<int>, no extra space required apart of that list
            List<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }

            return result;
        }
    }

    /*
     Runtime: 252 ms, faster than 23.14% of C# online submissions for Fizz Buzz.
Memory Usage: 34 MB, less than 23.64% of C# online submissions for Fizz Buzz.

    412. Fizz Buzz
Easy

Write a program that outputs the string representation of numbers from 1 to n.

But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.

Example:

n = 15,

Return:
[
    "1",
    "2",
    "Fizz",
    "4",
    "Buzz",
    "Fizz",
    "7",
    "8",
    "Fizz",
    "Buzz",
    "11",
    "Fizz",
    "13",
    "14",
    "FizzBuzz"
]
     */
}
