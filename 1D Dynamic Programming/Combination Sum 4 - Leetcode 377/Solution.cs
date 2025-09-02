namespace Leetcode_Solutions._1D_Dynamic_Programming.Combination_Sum_4___Leetcode_377;

public class Solution377
{
    public int CombinationSum4(int[] nums, int target)
    {
        var dp = new int[target + 1];
        dp[0] = 1;

        for (var i = 1; i < target + 1; i++)
        {
            foreach (var num in nums)
            {
                if (i >= num)
                {
                    dp[i] += dp[i - num];
                }
            }
        }

        return dp[target];
    }
}