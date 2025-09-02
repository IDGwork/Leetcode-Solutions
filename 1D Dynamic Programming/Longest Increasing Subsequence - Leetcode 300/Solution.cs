namespace Leetcode_Solutions._1D_Dynamic_Programming.Longest_Increasing_Subsequence___Leetcode_300;

public class Solution300
{
    public int LengthOfLIS(int[] nums)
    {
        var res = 0;
        
        var dp = new int[nums.Length];
        Array.Fill(dp, 1);

        for (var i = 1; i < nums.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (nums[i] > nums[j])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }

        for (var i = 0; i < nums.Length; i++)
        {
            res = Math.Max(res, dp[i]);
        }

        return res;
    }
}