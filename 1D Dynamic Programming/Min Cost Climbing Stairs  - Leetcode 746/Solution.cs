namespace Leetcode_Solutions._1D_Dynamic_Programming.Min_Cost_Climbing_Stairs____Leetcode_746;

public class Solution746
{
    public int MinCostClimbingStairs(int[] cost)
    {
        var n = cost.Length;
        var dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 0;

        for (var i = 2; i < n + 1; i++)
        {
            dp[i] = Math.Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);
        }

        return dp[n];
    }
}


//Algorithm:

//Approach - DP to compute the minimum cost to reach the top.

//Step 1 - Initialisation:
    //Define dp[i] as the min cost to reach step i:
        //We can start from step 0 or 1 freely. Hence:
            //dp[0] = 0.
            //dp[1] = 0.
//Step 2 - Fill dp table:
    //For i from 2 to n + 1:
        //dp[i] = min(dp[i - 1] + cost[i - 1], dp[i - 2], cost[i - 2]).
//Step 3 - Return:
    //Return dp[n], which represents the cost to reach the top (just beyond the last step).

//Time: O(n).
//Space: O(n).
