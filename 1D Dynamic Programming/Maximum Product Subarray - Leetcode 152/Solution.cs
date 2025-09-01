namespace Leetcode_Solutions._1D_Dynamic_Programming.Maximum_Product_Subarray___Leetcode_152;

public class Solution152
{
    public int MaxProduct(int[] nums)
    {
        var res = nums[0];
        var dpMax = new int[nums.Length];
        var dpMin = new int[nums.Length];
        dpMax[0] = nums[0];
        dpMin[0] = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            dpMax[i] = Math.Max(nums[i],
                Math.Max(dpMax[i - 1] * nums[i],
                    dpMin[i - 1] * nums[i]));

            dpMin[i] = Math.Min(nums[i],
                Math.Min(dpMax[i - 1] * nums[i],
                    dpMin[i - 1] * nums[i]));

            res = Math.Max(res, dpMax[i]);
        }

        return res;
    }
}