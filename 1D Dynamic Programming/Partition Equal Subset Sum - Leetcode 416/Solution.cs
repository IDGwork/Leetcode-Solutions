namespace Leetcode_Solutions._1D_Dynamic_Programming.Partition_Equal_Subset_Sum___Leetcode_416;

public class Solution416
{
    public bool CanPartition(int[] nums)
    {
        var total = 0;
        foreach (var num in nums) total += num;
        if (total % 2 != 0) return false;

        var target = total / 2;
        var dp = new bool[target + 1];
        dp[0] = true;

        foreach (var num in nums)
        {
            for (var i = target; i >= num; i--)
            {
                dp[i] = dp[i] || dp[i - num];
            }
        }

        return dp[target];
    } 
}