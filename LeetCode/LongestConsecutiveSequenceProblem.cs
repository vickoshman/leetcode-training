using System;
using System.Collections.Generic;

namespace LeetCode
{
  public class LongestConsecutiveSequenceProblem
  {
    public int LongestConsecutive(int[] nums)
    {
      if (nums.Length == 0)
        return 0;

      Array.Sort(nums);

      int max = 0;
      int prev = nums[0];
      int current = 0;

      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] == prev)
          continue;

        if (nums[i] == prev + 1)
        {
          current++;
          prev = nums[i];
          if (current > max)
            max = current;
          continue;
        }

        prev = nums[i];
        current = 0;
      }

      return max + 1;
    }
  }
}