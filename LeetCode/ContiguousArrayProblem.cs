using System;
using System.Collections.Generic;

namespace LeetCode
{
  public class ContiguousArrayProblem
  {
    public int FindMaxLength(int[] nums)
    {
      int max = 0;
      int count = 0;
      var dic = new Dictionary<int, int>();

      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] == 1) count++;
        if (nums[i] == 0) count--;

        if (dic.ContainsKey(count))
          max = Math.Max(max, i - dic[i]);
        else
          dic[count] = i;

        if (count == 0)
          max = i + 1;
      }

      return max;
    }
  }
}