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