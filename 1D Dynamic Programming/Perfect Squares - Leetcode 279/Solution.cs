namespace Leetcode_Solutions._1D_Dynamic_Programming.Perfect_Squares___Leetcode_279;

public class Solution279
{
    public int NumSquares(int n)
    {
        var dp = new int[n + 1];
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0;

        for (var i = 1; i < n + 1; i++)
        {
            for (var j = 1; j * j < i + 1; j++)
            {
                dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
            }
        }

        return dp[n];
    }
}


//Algorithm:

//Approach - Bottom-Up DP to find the fewest number of perfect
//squares summing to n.

//Step 1 - Initialisation:
    //Initialise dp = int[n + 1]. Fill with int.MaxValue as default.
    //Initialise dp[0] = 0 (0 perfect squares sum to 0).
//Step 2 - Fill DP table:
    //For each i from 1 to n:
        //Try every square j*j <= i:
            //Update dp[i] = min(dp[i], dp[i - j * j] + 1).
//Step 3 - Return:
    //Return dp[n] as the minimum number of perfect squares that
    //sum to n.

//Time: O( n * sqrt(n) ).
//Space: O(n).