namespace Leetcode_Solutions._1D_Dynamic_Programming.Climbing_Stairs___Leetcode_70;

public class Solution70
{
    public int ClimbStairs(int n)
    {
        if (n <= 2) return n;
        
        var dp = new int[n + 1];
        dp[1] = 1;
        dp[2] = 2;

        for (var i = 3; i < n + 1; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        
        return dp[n];
    }
}


//Algorithm:

//Approach -

//Step 1 - Initialisation:
    //dp[1] = 1 (1 way to reach step 1)
    //dp[2] = 2 (either 1 + 1 or 2 directly)
//Step 2 - Fill dp table:
    //For each i from 3 to n + 1, use dp[i] = dp[i - 1] + dp[i - 2]
    //since we can arrive from one or two steps below.
//Step 3 - Return:
    //Return dp[n] as the total ways to reach the top.

//Time: O(n)
//Space: O(n)
