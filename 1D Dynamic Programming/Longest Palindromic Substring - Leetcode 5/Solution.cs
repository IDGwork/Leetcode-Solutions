namespace Leetcode_Solutions._1D_Dynamic_Programming.Longest_Palindromic_Substring___Leetcode_5;

public class Solution5
{
    public string LongestPalindrome(string s)
    {
        if (s.Length == 0) return "";

        var n = s.Length;
        var dp = new bool[n];
        var start = 0;
        var maxLen = 1;

        for (var i = n - 1; i > -1; i--)
        {
            for (var j = n - 1; j > i - 1; j--)
            {
                if (s[i] == s[j] && (j - i < 2 || dp[j - 1]))
                {
                    dp[j] = true;
                    if (j - i + 1 > maxLen)
                    {
                        start = i;
                        maxLen = j - i + 1;
                    }
                }
                else
                {
                    dp[j] = false;
                }
            }
        }

        return s.Substring(start, maxLen);
    }
}


//Algorithm:

//Approach - Use 1D DP to track palindromic substrings using 
//a 1D DP array, optimising space from O(n^2) to O(n)

//Step 1 - Initialisation:
    //If string is empty, return "".
    //Define dp[j], where dp[j] = true if substring s[i..j]
    //is a palindrome.
//Step 2 - Fill DP table (reverse traversal):
    //Traverse i from n - 1 down to 0.
    //Traverse j from n - 1 down to i.
    //A substring s[i..j] is palindrome if:
        //Characters match: s[i] == s[j].
        //And either it's length < 2 (j - i > 2) or inner
        //substring is palindrome (dp[j - 1]).
    //If valid, mark dp[j] = true. Otherwise, reset to false.
//Step 3 - Track the longest palindrome:
    //Whenever a palindrome is found with length greater than
    //maxLen, update start and maxLen.
//Step 4 - Return:
    //Return s.Substring(start, maxLen).

//Time: O(n).
//Space: O(n).