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


//Algorithm:

//Approach - Bottom-Up DP to compute the longest increasing subsequence.

//Step 1 - Initialisation:
    //Initialise dp = int[nums.Length].
    //Initialise dp with all 1 values.
//Step 2 - Fill DP table:
    //For every i:
        //Loop over all j < i:
            //If nums[i] > nums[j]:
                //dp[i] = max(dp[i], dp[j] + 1).
//Step 3 - Return:
    //Return max value in dp, which stores the longest increasing subsequence.

//Time: O(n^2).
//Space: O(n).