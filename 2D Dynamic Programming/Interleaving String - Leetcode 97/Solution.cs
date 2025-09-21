namespace Leetcode_Solutions._2D_Dynamic_Programming.Interleaving_String___Leetcode_97;

public class Solution97
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s1.Length + s2.Length != s3.Length) return false;

        var dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[0, 0] = true;

        for (var i = 0; i < s1.Length + 1; i++)
        {
            for (var j = 0; j < s2.Length + 1; j++)
            {
                if (i > 0 && s1[i - 1] == s3[i + j - 1]) dp[i, j] |= dp[i - 1, j];
                if (j > 0 && s2[j - 1] == s3[i + j - 1]) dp[i, j] |= dp[i, j - 1];
            }
        }

        return dp[s1.Length, s2.Length];
    }
}


//Algorithm:

//Approach - 2D DP to check if s3 can be formed by interleaving s1 and s2.

//Step 1 - Initialisation:
    //Check if lengths match: If s1.Length + s2.Length != s3.Length, return false.
    //Initialise dp = bool[s1.Length + 1, s2.Length + 1], where dp[i, j] means
    //s3[0..i + j] can be formed by interleaving s1[0..i] and s2[0..j].
    //Initialise dp[0, 0] = true.
//Step 2 - Fill DP table:
    //Loop i from 0 to s1.Length + 1 and j from 0 to s2.Length + 1:
        //If i > 0 and s1[i - 1] == s3[i + j - 1], set dp[i, j] |= dp[i - 1, j].
        //If j > 0 and s2[j - 1] == s3[i + j - 1], set dp[i, j] |= dp[i, j - 1]. 
//Step 3 - Return:
    //Return dp[s1.Length, s2.Length].

//Time: O(s1 * s2).
//Space: O(s1 * s2).