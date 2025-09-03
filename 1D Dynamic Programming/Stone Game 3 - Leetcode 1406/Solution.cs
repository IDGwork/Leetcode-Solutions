namespace Leetcode_Solutions._1D_Dynamic_Programming.Stone_Game_3___Leetcode_1406;

public class Solution1406
{
    public string StoneGameIII(int[] stoneValue)
    {
        var n = stoneValue.Length;
        var dp = new int[n + 1];
        for (var i = 0; i < n; i++) dp[i] = int.MinValue;
        dp[n] = 0;

        for (var i = n - 1; i >= 0; i--)
        {
            var take = 0;
            for (var k = 0; k < 3 && i + k < n; k++)
            {
                take += stoneValue[i + k];
                dp[i] = Math.Max(dp[i], take - dp[i + k + 1]);
            }
        }

        if (dp[0] > 0) return "Alice";
        if (dp[0] < 0) return "Bob";
        return "Tie";
    }
}


//Algorithm:

//Approach - Bottom-Up DP. We simulate the game backwards, letting
//dp[i] represent the maximum score difference the current player
//can achieve starting from index i.

//Step 1 - Initialisation:
    //Initialise dp = int[n + 1].
    //dp[n] = 0 (the score difference is 0 with no stones left).
    //All other positions are initially set as int.MinValue.
//Step 2 - Fill DP table:
    //For each index i from n - 1 down to 0:
        //Consider taking 1, 2 or 3 stones.
        //Keep a running sum take of the chosen stones.
        //Update dp[i] = max(dp[i], take - dp[i + k + 1]) since
        //the opponent plays optimally next.
//Step 3 - Return:
    //Check dp[0]:
        //If positive - "Alice" wins.
        //If negative - "Bob" wins.
        //If 0 - "Tie".

//Time: O(n).
//Space: O(n).