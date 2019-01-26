using System;
using System.Collections.Generic;
using System.Globalization;

namespace LeetCode
{
  public class FindAllNumberDisappearedInAnArrayProblem
  {
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
      var result = new List<int>();

      if (nums.Length < 1)
        return result;

      Array.Sort(nums);

      int searched = -1;
      for (int i = 1; i <= nums.Length; i++)
      {
        if (searched != -1 && i == searched)
          continue;

        searched = i;
        int pos = Array.BinarySearch(nums, i);
        if (pos < 0)
          result.Add(i);
      }

      return result;
    }
  }
}