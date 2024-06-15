using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqAndLambdas
{
    public class LambdaExp
    {
        public static void LambdaEx() {
            
            //Example #1
            Func<int, int> times2 = (num) => num * 2;
            int result = times2(4);
            Console.WriteLine($"Times: {result}");

            //Example #2
            Func<int, int, int> addition = (n1, n2) => n1 + n2;
            result = addition(4, 13);
            Console.WriteLine($"Addition: {result}");

            //Example #3
            Func<int, bool> odd = (n1) => n1 % 2 == 0;
            Console.WriteLine($"Pair: {odd(7)}");

            //Example #4 - Use func lambda in WHERE LinQ
            List<int> nums = new List<int>() { 2, 3, 6, 7, 8, 11 };
            
            var pairs = nums.Where(odd);
            Console.WriteLine("PAIRS");
            foreach (int num in pairs) {
                Console.WriteLine(num);
            }

            //Example #5
            Func<int, int, int> greater = (n1, n2) => {
                if (n1 > n2) return n1;
                else return n2;
            };
            result = greater(5, 8);
            Console.WriteLine($"Greater: {result}");

            //Example #6 - Action (method encapsulated that doesn't return a value
            Action<int> print = (n) => Console.WriteLine(n);

            Action<List<int>> printList = (list) => {
                foreach (var n in list)
                    print(n);
            };

            printList(nums);

            //Example #7 - Func receiving other func
            Func<int, Func<int, int>, int> mainFn = (num, fn) => {
                if (num > 100)
                    return fn(num);
                else
                    return num;
            };

            result = mainFn(550, n => n * 2);
            Console.WriteLine($"Nested Func: {result}");
        }
    }
}
