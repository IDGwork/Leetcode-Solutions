namespace Leetcode_Solutions._2D_Dynamic_Programming.Stone_Game_II___Leetcode_1140;

public class Solution1140
{
    public int StoneGameII(int[] piles)
    {
        var dp = new int[piles.Length + 1, piles.Length + 1];
        var suffix = new int[piles.Length + 1];
        for (var i = piles.Length - 1; i >= 0; i--) suffix[i] = suffix[i + 1] + piles[i];

        for (var i = piles.Length - 1; i >= 0; i--)
        {
            for (var j = 1; j < piles.Length + 1; j++)
            {
                for (var x = 1; x < Math.Min(2 * j, piles.Length - i) + 1; x++) dp[i, j] = Math.Max(dp[i, j], suffix[i] - dp[i + x, Math.Max(j, x)]);
            }
        }

        return dp[0, 1];
    }
}


//Algorithm:

//Approach -  Bottom-Up DP to compute max stones player can get starting at index i with M.

//Step 1 - Initialisation:
    //Initialise dp = int[piles.Length + 1, piles.Length + 1].
    //Initialise suffix = int[piles.Length + 1] to store the total stones from index i to the end.
    //Initialise suffix[piles.Length] = 0 and fill it backwards using: suffix[i] = suffix[i + 1] + piles[i].
//Step 2 - Fill DP table:
    //Define dp[i, j] as the maximum stones the current player can get starting at pile i.
    //Traverse i from piles.Length - 1 to 0, and j from 1 to piles.Length.
    //For each possible x from 1 to 2 * j (number of piles to take), compute:
        //dp[i, j] = max(dp[i, j], suffix[i] - dp[i + x, max(j, x)])
//Step 3 - Return:
    //Return dp[0, 1] which gives max stones player 1 can get from start.

//Time: O(n^3).
//Space: O(n^2).