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


//Algorithm:

//Approach - Bottom-Up DP to count all combinations summing to target.

//Step 1 - Initialisation:
    //Initialise dp = int[target + 1];
    //Initialise dp[0] = 1 to represent one way to reach sum 0.
//Step 2 - Fill DP table:
    //Foreach sum i from 1 to target:
        //Foreach num in nums:
            //If i >= num:
                //Update dp[i] += dp[i - num].
//Step 3 - Return:
    //Return dp[target], which stores the amount of ways
    //to sum to target from nums.

//Time: O(n * target).
//Space: O(target).