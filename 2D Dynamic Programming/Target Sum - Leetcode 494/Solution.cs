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


//Algorithm:

//Approach - Use Dynamic Programming with a dictionary at each step to count
//how many ways we can reach a given sum. At every number, we can
//either add or subtract it. This builds all possible sums layer by layer.

//Step 1 - Initialisation:
    //dp[0][0] = 1 (There is exactly 1 way to reach sum 0 with no elements).
//Step 2 - Fill DP table:
    //For each number nums[i]:
    //For each sum already in dp[i]:
        //Add nums[i] to the sum: increment count for dp[i+1][total + nums[i]].
        //Subtract nums[i] from the sum: increment count for dp[i+1][total - nums[i]].
//Step 3 - Return:
    //Look up dp[n][target]. If target is reachable, return the count of ways;
    //otherwise return 0.

//Time: O(n * m), 
//Space: O(n * m)