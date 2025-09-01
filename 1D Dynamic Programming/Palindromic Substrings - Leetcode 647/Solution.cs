namespace Leetcode_Solutions._1D_Dynamic_Programming.Palindromic_Substrings___Leetcode_647;

public class Solution647
{
    public int CountSubstrings(string s)
    {
        var res = 0;
        var n = s.Length;
        var dp = new bool[n];

        for (var i = n - 1; i > -1; i--)
        {
            for (int j = i; j < n; j++)
            {
                if (s[i] == s[j] && (j - i < 3 || dp[j - 1]))
                {
                    dp[j] = true;
                    res++;
                }
                else
                {
                    dp[j] = false;
                }
            }
        }

        return res;
    }
}


//Algorithm:

//Approach - Use compressed DP where dp[j] tracks if substring
//s[i..j] is a palindrome. This reduces space from O(n^2) to O(n).

//Step 1 - Initialisation:
    //Let dp[j] represent whether substring s[i..j] is a palindrome
    //for the current i.
    //Initialise result counter res = 0.
//Step 2 - Reverse traversal:
    //Loop i from n - 1 down to 0.
    //For each i, loop j from i up to n - 1.
    //A substring s[i..j] is palindrome if:
        //Characters match (s[i] == s[j]), and
        //either length < 3 (j - i < 3) or the inner
        //substring s[i+1..j-1] was palindrome (dp[j - 1]).
//Step3 - Count:
    //If valid, mark dp[j] = true and increment res.
    //Otherwise, reset dp[j] = false.
//Step 4 - Return:
    //Return res as the total count of palindromic substrings.

//Time: O(n^2).
//Space: O(n).