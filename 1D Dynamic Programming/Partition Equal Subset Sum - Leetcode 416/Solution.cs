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


//Algorithm:

//Approach - Bottom-Up DP for subset sum to half of total.

//Step 1 - Initialisation:
    //Initialise total = 0 and count nums total.
    //If total % 2 != 0 (ie impossible to have 2 equal sub-arrays)
    //return false straight away.
    //Initialise target = total / 2 (total we need in sub-arrays).
    //Initialise dp = bool[target + 1].
    //Initialise dp[0] = true.
//Step 2 - Fill DP table:
    //Iterate over each number:
        //Iterate backwards from target while >= num:
            //Update dp: If dp[i - num] is true, set dp[i] = true.
//Step 3 - Return:
    //Return dp[total / 2]. 

//Time: O( n * (sum / 2) ).
//Space: O(sum / 2).