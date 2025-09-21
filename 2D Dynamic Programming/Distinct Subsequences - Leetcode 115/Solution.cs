namespace Leetcode_Solutions._2D_Dynamic_Programming.Distinct_Subsequences___Leetcode_115;

public class Solution115
{
    public int NumDistinct(string s, string t)
    {
        var dp = new int[s.Length + 1, t.Length + 1];
        for (var i = 0; i < s.Length + 1; i++) dp[i, 0] = 1;

        for (var i = 1; i < s.Length + 1; i++)
        {
            for (var j = 1; j < t.Length + 1; j++)
            {
                if (s[i - 1] == t[j - 1]) dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
                else dp[i, j] = dp[i - 1, j];
            }
        }

        return dp[s.Length, t.Length];
    }
}


//Algorithm:

//Approach - 2D DP to count subsequences of s that form t.

//Step 1 - Initialisation:
    //Initialise dp = int[s.Length +1, t.Length + 1], where dp[i, j] means:
    //number of ways first j chars of t appear in first i chars of s.
    //Initialise dp[i, 0] = 1 for all i, since empty t is a subsequence of any prefix of s.
//Step 2 - Fill DP table:
    //For each i from 1 to s.Length:
        //For each j from 1 to t.Length:
            //If s[i - 1] == t[j - 1]: dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j].
            //Else: dp[i, j] = dp[i - 1, j]. 
//Step 3 - Return:
    //Return dp[s.Length, t.Length].

//Time: O(s.Length * t.Length).
//Space: O(s.Length * t.Length).