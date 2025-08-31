namespace Leetcode_Solutions._1D_Dynamic_Programming.House_Robber____Leetcode_198;

public class Solution198
{
    public int Rob(int[] nums)
    {
        var n = nums.Length;
        if (n == 0) return 0;
        if (n == 1) return nums[0];
        
        var dp = new int[n];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);


        for (var i = 2; i < n; i++)
        {
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
        }

        return dp[n - 1];
    }   
}


//Algorithm:

//Approach - DP to store the max loot up to each house.

//Step 1 - Initialisation:
    //Define dp[i] as the max money rob-able from houses [0..i].
    //Base cases:
        //dp[0] = nums[0].
        //dp[1] = max(nums[0], nums[1]).
//Step 2 - Fill dp table:
    //For i from 2 to n - 1:
        //dp[i] = max(dp[i - 1], dp[i - 2] + nums[i]).
//Step 3 - Return:
    //Return dp[n - 1].

//Time: O(n).
//Space: O(n).