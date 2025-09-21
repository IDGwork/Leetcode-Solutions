namespace Leetcode_Solutions._2D_Dynamic_Programming.Last_Stone_Weight_II___Leetcode_1049;

public class Solution1049
{
    public int LastStoneWeightII(int[] stones)
    {
        var total = 0;
        foreach (var stone in stones) total += stone;
        var target = total / 2;

        var dp = new bool[stones.Length + 1, target + 1];
        dp[0, 0] = true;

        for (var i = 1; i < stones.Length + 1; i++)
        {
            for (var j = 0; j < target + 1; j++)
            {
                dp[i, j] = dp[i - 1, j];
                if (j >= stones[i - 1]) dp[i, j] |= dp[i - 1, j - stones[i - 1]];
            }
        }

        for (int j = target; j >= 0; j--)
        {
            if (dp[stones.Length, j]) return total - 2 * j;
        }

        return 0;
    }
}


//Algorithm:

//Approach - DP to find the closest subset sum to half the total weight.

//Step 1 - Initialisation:
    //Initialise total sum of stones.
    //Initialise target = total / 2.
    //Initialise dp = bool[stones.Length + 1, target + 1].
    //Initialise dp[0, 0] = true.
//Step 2 - Fill DP table:
    //For each stone i:
        //For each weight j:
            //Either exclude the stone: dp[i, j] = dp[i - 1, j].
            //Or include it if possible: dp[i, j] |= dp[i - 1, j - stones[i - 1]].
//Step 4: Find the best partition:
    //Iterate from target down to 0.
    //The largest j where dp[n, j] is true gives one subset sum.
//Step 3 - Return:
    //Return total - 2 * j as the minimal difference between two piles.

//Time: O(n * sum).
//Space: O(n * sum).