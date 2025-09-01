namespace Leetcode_Solutions._1D_Dynamic_Programming.Decode_Ways___Leetcode_91;

public class Solution91
{
    public int NumDecodings(string s)
    {
        if (s.Length == 0 || s[0] == '0') return 0;

        var dp = new int[s.Length + 1];
        dp[0] = 1;
        dp[1] = 1;

        for (var i = 2; i < s.Length + 1; i++)
        {
            if (s[i - 1] != '0')
            {
                dp[i] += dp[i - 1];
            }

            var twoDigit = int.Parse(s.Substring(i - 2, 2));
            if (twoDigit >= 10 && twoDigit <= 26)
            {
                dp[i] += dp[i - 2];
            }
        }

        return dp[s.Length];
    }
}


//Algorithm:

//Approach - DP to count valid ways to decode each prefix
//of the string.

//Step 1 - Initialisation:
    //If s.Length == 0 or s[0] = '0', return 0.
    //Declare dp[s.Length + 1].
    //Initialise dp[0] = 1.
    //Initialise dp[1] = 1.
//Step 2 - Iterate from i = 2 to s.Length:
    //If s[i - 1] != '0', add dp[i - 1] (single digit decode).
    //If s[i - 2..i] is between 10 and 26 inclusive, add dp[i - 2]
    //(double digit decode).
//Step 3 - Return:
//    Return dp[n] as total ways to decode the string.

//Time: O(n).
//Space: O(n).