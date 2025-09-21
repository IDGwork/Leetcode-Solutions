namespace Leetcode_Solutions._2D_Dynamic_Programming.Coin_Change_II___Leetcode_518;

public class Solution518
{
    public int Change(int amount, int[] coins)
    {
        var dp = new int[coins.Length + 1, amount + 1];
        dp[0, 0] = 1;

        for (var i = 1; i < coins.Length + 1; i++)
        {
            for (var j = 0; j < amount + 1; j++)
            {
                dp[i, j] = dp[i - 1, j];
                if (j >= coins[i - 1]) dp[i, j] += dp[i, j - coins[i - 1]];
            }
        }

        return dp[coins.Length, amount];
    }
}


//Algorithm:

//Approach - 2D Bottom-Up DP to count combinations to reach amount
//using coins.

//Step 1 - Initialisation:
    //Initialise dp[n + 1, amount + 1], where dp[i, j] means the
    //number of ways to make sum j using first i coins.
    //Initialise dp[0, 0] = 1 (1 way to make 0 with 0 coins).
//Step 2 - Fill DP table:
    //For each coin i = 1 to n:
        //For each target sum j = 0 to amount:
            //Copy ways without this coin: dp[i, j] = dp[i - 1, j].
            //If j > coins[i - 1], add ways using this coin:
            //dp[i, j] += dp[i, j - coins[i - 1]].
//Step 3 - Return:
    //Return dp[coins.Length, amount] as the final result.

//Time: O(n * amount).
//Space: O(n * amount).