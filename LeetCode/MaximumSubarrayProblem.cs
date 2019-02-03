using System;
using System.Data;

namespace LeetCode
{
  public class MaximumSubarrayProblem
  {
    static int MaxCrossingSum(int[] arr, int l, int m, int h)
    {
      int sum = 0;
      int leftSum = int.MinValue;
      for (int i = m; i >= l; i--)
      {
        sum += arr[i];
        if (sum > leftSum)
          leftSum = sum;
      }

      sum = 0;
      int rightSum = int.MinValue;
      for (int i = m + 1; i <= h; i++)
      {
        sum += arr[i];
        if (sum > rightSum)
          rightSum = sum;
      }

      return leftSum + rightSum;
    }

    static int MaxSubArraySum(int[] arr, int l, int h)
    {
      if (l == h)
        return arr[l];

      int m = (l + h) / 2;

      return Math.Max(
        Math.Max(MaxSubArraySum(arr, l, m),
                 MaxSubArraySum(arr, m + 1, h)),
                 MaxCrossingSum(arr, l, m, h));
    }

    public int MaxSubArray(int[] nums)
    {
      if (nums == null || nums.Length == 0)
        return 0;

      var maxSoFar = nums[0];
      var currentMax = nums[0];

      for (int i = 0; i < nums.Length; i++)
      {
        currentMax = Math.Max(nums[i], currentMax + nums[i]);
        maxSoFar = Math.Max(maxSoFar, currentMax);
      }

      return maxSoFar;
    }
  }
}