namespace Leetcode_Solutions._2D_Dynamic_Programming.Unique_Paths_II___Leetcode_63;

public class Solution63
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        if (obstacleGrid[0][0] == 1) return 0;
        var rows = obstacleGrid.Length;
        var cols = obstacleGrid[0].Length;
        
        var dp = new int[rows, cols];
        dp[0, 0] = 1;
        for (var r = 1; r < rows; r++) dp[r, 0] = obstacleGrid[r][0] == 0 ? dp[r - 1, 0] : 0;
        for (var c = 1; c < cols; c++) dp[0, c] = obstacleGrid[0][c] == 0 ? dp[0, c - 1] : 0;

        for (var r = 1; r < rows; r++)
        {
            for (var c = 1; c < cols; c++)
            {
                if (obstacleGrid[r][c] == 0)
                {
                    dp[r, c] = dp[r - 1, c] + dp[r, c - 1];
                }
            }
        }

        return dp[rows - 1, cols - 1];
    }
}