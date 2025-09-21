namespace Leetcode_Solutions._2D_Dynamic_Programming.Stone_Game___Leetcode_877;

public class Solution877
{
    public bool StoneGame(int[] piles)
    {
        var dp = new int[piles.Length, piles.Length];
        for (var i = 0; i < piles.Length; i++) dp[i, i] = piles[i];

        for (var len = 2; len < piles.Length + 1; len++)
        {
            for (var i = 0; i < piles.Length + 1 - len; i++)
            {
                var j = i + len - 1;
                dp[i, j] = Math.Max(piles[i] - dp[i + 1, j], piles[j] - dp[i, j - 1]);
            }
        }

        return dp[0, piles.Length - 1] > 0;
    }
}


//Algorithm:

//Approach - Bottom-Up DP to find max score difference between Alex and Lee.

//Step 1 - Initialisation:
    //Declare dp[piles.Length, piles.Length], where
    //dp[i, j] = max score difference Alex can get from subarray [i..j].
    //Initialise dp[i, j] = piles[i] since only one pile is taken.
//Step 2 - Fill DP table:
    //Loop over lengths from 2 to n:
        //For each range [i..j]:
            //dp[i, j] = max(piles[i] - dp[i + 1, j], piles[j] - dp[i, j - 1]).
            //This represents the optimal move difference Alex can enforce.
//Step 3 - Return:
    //Return dp[0, n - 1] > 0 to check if Alex wins.

//Time: O(n^2).
//Space: O(n^2).