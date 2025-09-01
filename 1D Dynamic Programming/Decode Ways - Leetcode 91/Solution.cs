namespace Leetcode_Solutions._1D_Dynamic_Programming.Decode_Ways___Leetcode_91;

public class Solution91
{
    public int NumDecodings(string s)
    {
        if (s.Length == 0 || s[0] == '0') return 0;

        var dp = new int[s.Length + 1];
        dp[0] = 1;
        dp[1] = 1;

        for (var i = 2; i < s.Length + 1; i++)
        {
            if (s[i - 1] != '0')
            {
                dp[i] += dp[i - 1];
            }

            var twoDigit = int.Parse(s.Substring(i - 2, 2));
            if (twoDigit >= 10 && twoDigit <= 26)
            {
                dp[i] += dp[i - 2];
            }
        }

        return dp[s.Length];
    }
}