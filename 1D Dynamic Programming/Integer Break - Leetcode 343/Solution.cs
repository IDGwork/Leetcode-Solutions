namespace Leetcode_Solutions._1D_Dynamic_Programming.Integer_Break___Leetcode_343;

public class Solution343
{
    public int IntegerBreak(int n)
    {
        var dp = new int[n + 1];
        dp[1] = 1;

        for (var i = 2; i < n + 1; i++)
        {
            for (var j = 1; j < i; j++)
            {
                dp[i] = Math.Max(dp[i], Math.Max(j * (i - j), j * dp[i - j]));
            }
        }

        return dp[n];
    }
}


//Algorithm:

//Approach - Bottom-Up DP to find the max product from integer break.

//Step 1 - Initialisation:
    //Initialise dp = int[n + 1].
    //Initialise dp[1] = 1.
//Step 2 - Fill dp table:
    //For each total i from 2 to n:
        //For each split point j from 1 to i - 1:
            //Update dp[i] = max(dp[i], max(j * (i - j), j * dp[i - j])).
//Step 3 - Return:
    //Return dp[n].

//Time: O(n^2).
//Space: O(n).