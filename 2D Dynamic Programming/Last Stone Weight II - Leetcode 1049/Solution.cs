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