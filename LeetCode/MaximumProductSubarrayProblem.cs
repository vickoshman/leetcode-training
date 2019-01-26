using System;

namespace LeetCode
{
  public class MaximumProductSubarrayProblem
  {
    public int MaxProduct(int[] nums)
    {
      int max = int.MinValue;
      int current = 1;

      for (int i = 0; i < nums.Length; i++)
      {
        for (int j = i; j < nums.Length; j++)
        {
          current *= nums[j];
          if (current > max)
            max = current;
        }

        current = 1;
      }

      return max;
    }
  }
}