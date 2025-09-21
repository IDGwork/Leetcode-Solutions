namespace Leetcode_Solutions._2D_Dynamic_Programming.Interleaving_String___Leetcode_97;

public class Solution97
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s1.Length + s2.Length != s3.Length) return false;

        var dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[0, 0] = true;

        for (var i = 0; i < s1.Length + 1; i++)
        {
            for (var j = 0; j < s2.Length + 1; j++)
            {
                if (i > 0 && s1[i - 1] == s3[i + j - 1]) dp[i, j] |= dp[i - 1, j];
                if (j > 0 && s2[j - 1] == s3[i + j - 1]) dp[i, j] |= dp[i, j - 1];
            }
        }

        return dp[s1.Length, s2.Length];
    }
}