namespace Leetcode_Solutions._2D_Dynamic_Programming.Minimum_Path_Sum___Leetcode_64;

public class Solution64
{
    public int MinPathSum(int[][] grid)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;

        var dp = new int[rows, cols];
        dp[0, 0] = grid[0][0];
        for (var r = 1; r < rows; r++) dp[r, 0] = dp[r - 1, 0] + grid[r][0];
        for (var c = 1; c < cols; c++) dp[0, c] = dp[0, c - 1] + grid[0][c];

        for (var r = 1; r < rows; r++)
        {
            for (var c = 1; c < cols; c++)
            {
                dp[r, c] = Math.Min(dp[r - 1, c], dp[r, c - 1]) + grid[r][c];
            }
        }

        return dp[rows - 1, cols - 1];
    }
}


//Algorithm:

//Approach - Bottom-Up 2D DP to find minimal path sum.

//Step 1 - Initialisation:
    //Initialise dp[rows, cols].
    //Initialise dp[0, 0] = grid[0][0].
    //Fill first row and first column with cumulative sums.
//Step 2 - Fill DP table:
    //For every dp[r, c], set:
        //dp[r, c] = min(dp[r - 1, c], dp[r, c - 1]) + grid[r][c].
//Step 3 - Return:
    //Return dp[rows - 1, cols - 1].

//Time: O(rows * cols).
//Space: O(rows * cols).