namespace Leetcode_Solutions._1D_Dynamic_Programming.Word_Break___Leetcode_139;

public class Solution139
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        var set = new HashSet<string>(wordDict);
        var dp = new bool[s.Length + 1];
        dp[0] = true;

        for (var i = 1; i < s.Length + 1; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (dp[j] && set.Contains(s.Substring(j, i - j)))
                {
                    dp[i] = true;
                    break;
                }
            }
        }

        return dp[s.Length];
    }
}


//Algorithm:

//Approach - Bottom up dp to check if string can be segmented using dictionary.

//Step 1 - Initialisation:
    //Declare set = HashSet<string>(wordDict) (remove duplicates from wordDict).
    //Declare dp = bool[s.Length + 1].
    //Initialise dp[0] = true.
//Step 2 - Fill DP table:
    //For each i:
        //Check all j < i.
        //If dp[j] = true and s[j..i - 1] is in the dictionary, set dp[i] = true.
//Step 3 - Return:
    //Return dp[n], which is true if the full string can be segmented.

//Time: O(n^2).
//Space: O(n).