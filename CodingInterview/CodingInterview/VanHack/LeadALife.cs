using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.VanHack
{
    class LeadALife
    {
        /*
 * Complete the 'calculateProfit' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER n
 *  2. INTEGER_ARRAY earning
 *  3. INTEGER_ARRAY cost
 *  4. INTEGER e
 */

        public static int calculateProfit(int n, List<int> earning, List<int> cost, int e)
        {
            int balance = 0;
            Console.WriteLine($"n : {n}");
            Console.WriteLine($"e : {e}");
            for (int d = 0; d < n; d++)
            {
                int _earn = earning[d];
                int _cost = cost[d];

                if (_earn <= _cost && d != n - 1)
                    continue;

                Console.WriteLine($"Earn {d}: {_earn}");
                Console.WriteLine($"Cost {d}: {_cost}");

                if (d == n - 1)
                { //last day?
                    balance += (_earn * e);
                }
                else
                {
                    balance += (_earn * e) - (_cost * e);
                }
                Console.WriteLine($"Balance {d}: {balance}");
            }

            return balance;
        }
    }
}
