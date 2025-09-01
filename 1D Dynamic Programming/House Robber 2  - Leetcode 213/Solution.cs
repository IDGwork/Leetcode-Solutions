namespace Leetcode_Solutions._1D_Dynamic_Programming.House_Robber_2____Leetcode_213;

public class Solution213
{
    public int Rob(int[] nums)
    {
        var n = nums.Length;
        if (n == 0) return 0;
        if (n == 1) return nums[0];

        int RobLinear(int[] nums)
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

        var case1 = new int[n - 1];
        var case2 = new int[n - 1];
        for (var i = 0; i < n - 1; i++) case1[i] = nums[i];
        for (var i = 1; i < n; i++) case2[i - 1] = nums[i];

        return Math.Max(RobLinear(case1), RobLinear(case2));
    }
}


//Algorithm:

//Approach - DP with two passes to handle circular house layout.

//Step 1 - Initialisation:
    //Since the first and last houses are neighbors, split
    //the problem:
        //Case 1: Rob houses from index 0 to n - 2.
        //Case 2: Rob houses from index 1 to n - 1.
//Step 2 - For each case, use linear DP:
    //Define dp[i] as the max money rob-able from the subarray
    //up to index i.
    //Base cases:
        //dp[0] = nums[0]
        //dp[1] = max(nums[0], nums[1]).
    //Fill the table:
        //For i from 2 to n - 1:
            //dp[i] = max(dp[i - 1], dp[i - 2] + nums[i]).
//Step 3 - Return:
//    Return the maximum result of the two cases.

//Time: O(n).
//Space: O(n).