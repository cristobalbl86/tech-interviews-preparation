using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview
{
    class _46_Coin_Change
    {
        /*
    Time: O(amount*n) where n is the number of coins
    Space: O(amount)
*/
        public static int CoinChange(int[] coins, int amount)
        {
            //dp[i]: min number of coins to make up amount i
            int[] dp = new int[amount + 1];
            //assign a large value to each amount i to indicate dp[i] is not optimized yet
            Array.Fill(dp, amount + 1);
            //there is no way to make up amount 0
            dp[0] = 0;

            for (int i = 0; i <= amount; i++)
            {
                // take coins[j] as the last coin we use to make up amount i
                for (int j = 0; j < coins.Length; j++)
                {
                    // after taking one coins[j], update dp[i] if the remaining >= 0
                    if (i - coins[j] >= 0)
                    {
                        //dp[i-coins[j]]: min number of coins to make up the remaining number
                        //1: use one coins[j]
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                    }
                }
            }

            return dp[amount] == amount + 1 ? -1 : dp[amount];
        }
    }
}
