namespace Leetcode_Solutions._2D_Dynamic_Programming.Distinct_Subsequences___Leetcode_115;

public class Solution115
{
    public int NumDistinct(string s, string t)
    {
        var dp = new int[s.Length + 1, t.Length + 1];
        for (var i = 0; i < s.Length + 1; i++) dp[i, 0] = 1;

        for (var i = 1; i < s.Length + 1; i++)
        {
            for (var j = 1; j < t.Length + 1; j++)
            {
                if (s[i - 1] == t[j - 1]) dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
                else dp[i, j] = dp[i - 1, j];
            }
        }

        return dp[s.Length, t.Length];
    }
}