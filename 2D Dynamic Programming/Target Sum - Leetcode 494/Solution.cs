namespace Leetcode_Solutions._2D_Dynamic_Programming.Target_Sum___Leetcode_494;

public class Solution494
{
    public int FindTargetSumWays(int[] nums, int target)
    {
        var n = nums.Length;
        var dp = new Dictionary<int, int>[n + 1];
        for (var i = 0; i < n + 1; i++) dp[i] = new Dictionary<int, int>();
        dp[0][0] = 1;

        for (var i = 0; i < n; i++)
        {
            foreach (var entry in dp[i])
            {
                var total = entry.Key;
                var count = entry.Value;
                if (!dp[i + 1].ContainsKey(total + nums[i])) dp[i + 1][total + nums[i]] = 0;
                dp[i + 1][total + nums[i]] += count;
                if (!dp[i + 1].ContainsKey(total - nums[i])) dp[i + 1][total - nums[i]] = 0;
                dp[i + 1][total - nums[i]] += count;
            }
        }

        return dp[n].ContainsKey(target) ? dp[n][target] : 0;
    }
}