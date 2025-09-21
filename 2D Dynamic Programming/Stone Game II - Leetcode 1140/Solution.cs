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