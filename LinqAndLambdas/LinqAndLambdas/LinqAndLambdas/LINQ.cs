using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqAndLambdas
{
    class LINQ
    {
        public static void MainLINQ()
        {
            int[] numbers = { 2, 4, 9, 5, 1, 0, 4, 7, 8, 3, 6 };

            var filteredNums = from number in numbers
                               where number < 5 || number == 8
                               orderby number descending
                               select number;

            Console.WriteLine(string.Join(", ", filteredNums));

            var filteredNumsL = numbers.Where(n => n < 5 || n == 8).OrderByDescending(n => n);
            Console.WriteLine(string.Join(", ", filteredNumsL));


            //LAMBDA
            List<int> listnumbers = new List<int>() { 5,6,3,2,1,7,8,4,234,653};

            var oddNumbers = from n in listnumbers
                             where n % 2 == 1
                             select n;

            var oddnumbersL = listnumbers.Where(n => n % 2 == 1);

            Console.WriteLine(string.Join(",", oddNumbers));
            Console.WriteLine(string.Join(",", oddnumbersL));
        }
    }
}
