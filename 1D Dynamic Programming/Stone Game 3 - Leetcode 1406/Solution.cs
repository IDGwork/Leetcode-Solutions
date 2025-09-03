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