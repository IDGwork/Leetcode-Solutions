namespace Leetcode_Solutions._2D_Dynamic_Programming.Unique_Paths___Leetcode_62;

public class Solution62
{
    public int UniquePaths(int m, int n)
    {
        var rows = m;
        var cols = n;

        var dp = new int[rows, cols];
        for (var r = 0; r < rows; r++) dp[r, 0] = 1;
        for (var c = 0; c < cols; c++) dp[0, c] = 1;

        for (var r = 1; r < rows; r++)
        {
            for (var c = 1; c < cols; c++)
            {
                dp[r, c] = dp[r - 1, c] + dp[r, c - 1];
            }
        }

        return dp[rows - 1, cols - 1];
    }
}


//Algorithm:

//Approach - 2D DP to count ways from top-left to bottom-right.

//Step 1 - Initialisation:
    //Initialise a 2D array dp[rows, cols].
    //Initialise all cells in first row and first column to 1.
    //since there is only one way to reach them.
//Step 2 - Fill DP table:
    //From cell (1, 1) to (rows - 1, cols - 1):
        //dp[r, c] = dp[r - 1, c] (from top) + dp[r, c - 1] (from left).
//Step 3 - Return:
    //Return dp[rows - 1, cols - 1] as the total unique paths.

//Time: O(rows * cols).
//Space: O(rows * cols).