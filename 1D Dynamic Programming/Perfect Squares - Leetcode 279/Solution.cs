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

//Approach - Problem-specific description

//Step 1 - Initialisation:
//    Base case setup
//Step 2 - Core logic (e.g., Fill dp table, Traverse graph)
//Step 3 - Return:
//    Return final computed result

//Time: O(n).
//Space: O(n).