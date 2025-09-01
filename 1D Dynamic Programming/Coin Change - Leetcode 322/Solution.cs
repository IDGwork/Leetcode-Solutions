namespace Leetcode_Solutions._1D_Dynamic_Programming.Coin_Change___Leetcode_322;

public class Solution322
{
    public int CoinChange(int[] coins, int amount)
    {
        var dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;

        for (var i = 1; i < amount + 1; i++)
        {
            foreach (var coin in coins)
            {
                if (i - coin >= 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }
}


//Algorithm:

//Approach - Bottom-up DP to build minimum coins needed for each amount.

//Step 1 - Initialisation:
    //Declare dp[amount + 1].
    //Initialise the dp with all (amount + 1).
    //Initialise dp[0] = 0.
//Step 2 - Iterate from i = 1 to amount:
    //For each coin, if i - coin >= 0:
        //Update dp[i] = min(dp[i], dp[i - coin]) + 1.
//Step 3 - Return:
    //Return dp[amount].

//Time: O(amount * n).
//Space: O(amount).