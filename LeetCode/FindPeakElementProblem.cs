﻿namespace LeetCode
{
  public class FindPeakElementProblem
  {
    public int FindPeakElement(int[] nums)
    {
      if (nums.Length == 0)
        return -1;

      if (nums.Length == 1)
        return 0;

      if (nums.Length >= 2 && nums[0] > nums[1])
        return 0;

      if (nums.Length >= 2 && nums[nums.Length - 1] > nums[nums.Length - 2])
        return nums.Length - 1;

      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
          return i;
      }

      return -1;
    }
  }
}