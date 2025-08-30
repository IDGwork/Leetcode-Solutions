namespace Leetcode_Solutions._1D_Dynamic_Programming.N_th_Tribonacci_Number___Leetcode_1137;

public class Solution1137
{
    public int Tribonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1 || n == 2) return 1;
        
        var dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        dp[2] = 1;

        for (var i = 3; i < n + 1; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
        }
        
        return dp[n];
    }    
}


//Algorithm:

//Approach - DP to build Tribonacci numbers from base cases.

//Step 1 - Initialisation:
    //Define dp[i] as the i'th Tribonacci number:
        //Base cases:
            //dp[0] = 0.
            //dp[1] = 1.
            //dp[2] = 1.
//Step 2 - Fill dp table:
    //For i from 3 to n + 1:
        //dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3].
//Step 3 - Return:
//    Return dp[n].

//Time: O(n).
//Space: O(n).