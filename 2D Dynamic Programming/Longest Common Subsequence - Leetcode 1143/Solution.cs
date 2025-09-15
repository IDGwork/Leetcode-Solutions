namespace Leetcode_Solutions._2D_Dynamic_Programming.Longest_Common_Subsequence___Leetcode_1143;

public class Solution1143
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var l1 = text1.Length;
        var l2 = text2.Length;

        var dp = new int[l1 + 1, l2 + 1];

        for (var i = 1; i < l1 + 1; i++)
        {
            for (var j = 1; j < l2 + 1; j++)
            {
                if (text1[i - 1] == text2[j - 1]) dp[i, j] = dp[i - 1, j - 1] + 1;
                else dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        return dp[l1, l2];
    }
}