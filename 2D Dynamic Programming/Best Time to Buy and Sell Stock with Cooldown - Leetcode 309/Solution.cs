namespace Leetcode_Solutions._2D_Dynamic_Programming.Best_Time_to_Buy_and_Sell_Stock_with_Cooldown___Leetcode_309;

public class Solution309
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0) return 0;

        var dpSell = new int[prices.Length];
        var dpBuy = new int[prices.Length];
        dpSell[0] = 0;
        dpBuy[0] = -prices[0];

        for (var i = 1; i < prices.Length; i++)
        {
            dpBuy[i] = Math.Max(dpBuy[i - 1], (i >= 2 ? dpSell[i - 2] : 0) - prices[i]);
            dpSell[i] = Math.Max(dpSell[i - 1], dpBuy[i - 1] + prices[i]);
        }

        return dpSell[prices.Length - 1];
    }
}