using System;
using System.Data;

namespace LeetCode
{
  public class MaximumSubarrayProblem
  {
    private int MaxSum(int[] nums, int start, int end, int max)
    {
      if (start >= end)
        return max;

      int sum = nums[start];
      for (int i = start + 1; i < end + 1; i++)
      {
        sum += nums[i];
        if (sum > max)
          max = sum;
      }

      int mid = (start + end) / 2;
      return Math.Max(Math.Max(
        MaxSum(nums, start, mid, max),
        MaxSum(nums, mid + 1, end, max)),
        MaxSum(nums, start + 1, end - 1, max));
    }

    public int MaxSubArray(int[] nums)
    {
      if (nums == null || nums.Length == 0)
        return 0;

      return MaxSum(nums, 0, nums.Length - 1, int.MinValue);
    }
  }
}