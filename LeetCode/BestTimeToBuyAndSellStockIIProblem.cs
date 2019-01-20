using System;
using System.Runtime.InteropServices;

namespace LeetCode
{
  public class BestTimeToBuyAndSellStockIIProblem
  {
    public int MaxProfit(int[] prices)
    {
      if (prices.Length < 1)
        return 0;

      int buy = prices[0];
      int profit = 0;
      for (int i = 1; i <= prices.Length - 1; i++)
      {
        if (prices[i] > buy)
        {
          profit += prices[i] - buy;
          buy = prices[i];
        }
        else
        {
          buy = prices[i];
        }
      }

      return profit;
    }
  }
}