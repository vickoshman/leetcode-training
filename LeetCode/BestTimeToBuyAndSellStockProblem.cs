using System.Runtime.InteropServices.ComTypes;

namespace LeetCode
{
  public class BestTimeToBuyAndSellStockProblem
  {
    public int MaxProfit(int[] prices)
    {
      int maxProfit = 0;
      
      for (int i = 0; i < prices.Length - 1; i++)
      {
        for (int j = i + 1; j < prices.Length; j++)
        {
          var profit = prices[j] - prices[i];
          if (profit > maxProfit)
            maxProfit = profit;
        }
      }

      return maxProfit;
    }
  }
}