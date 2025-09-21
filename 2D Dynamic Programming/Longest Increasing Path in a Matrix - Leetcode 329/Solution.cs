namespace Leetcode_Solutions._2D_Dynamic_Programming.Longest_Increasing_Path_in_a_Matrix___Leetcode_329;

public class Solution329
{
    public int LongestIncreasingPath(int[][] matrix)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        var res = 0;

        var dp = new int[rows, cols];
        var dirs = new int[][]
        {
            new int[] {1, 0}, new int[] {-1, 0},
            new int[] {0, 1}, new int[] {0, -1}
        };
        
        int Dfs(int r, int c)
        {
            if (dp[r, c] != 0) return dp[r, c];

            var maxLen = 1;
            foreach (var dir in dirs)
            {
                var nr = r + dir[0];
                var nc = c + dir[1];
                
                if (nr >= 0 && nr < rows &&  nc >= 0 && nc < cols && matrix[nr][nc] > matrix[r][c]) maxLen = Math.Max(maxLen, 1 + Dfs(nr, nc));
            }
            
            dp[r, c] = maxLen;
            return maxLen;
        }
        
        for (var r = 0; r < rows; r++)
        {
            for (var c = 0; c < cols; c++)
            {
                res = Math.Max(res, Dfs(r, c));
            }
        }

        return res;
    }
}


//Algorithm:

//Approach - DP + dfs memoization to store the longest increasing path from each cell.

//Step 1 - Initialisation:
    //Initialise rows, cols.
    //Initialise dp = int[rows, cols].
    //Initialise dirs.
    //Initialise method Dfs(int r, int c).
//Step 2 - Dfs:
    //For each (r, c) recursively explore up/down/left/right if neighbor is strictly greater.
    //Use memoization to avoid recomputation.
//Step 3 - Return:
    //Loop over all cells and return the maximum dp[r][c] found.

//Time: O(rows * cols).
//Space: O(rows * cols).