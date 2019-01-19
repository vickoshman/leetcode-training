using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
  public class SubsetsIIProblem
  {
    private void Explore(int[] nums, int from, List<int> soFar, List<IList<int>> result)
    {
      result.Add(soFar.ToList());
      if (from >= nums.Length)
      {
        return;
      }

      var used = new HashSet<int>();
      for (int i = from; i < nums.Length; i++)
      {
        if (used.Contains(nums[i]))
          continue;

        soFar.Add(nums[i]);
        Explore(nums, i + 1, soFar, result);
        soFar.RemoveAt(soFar.Count - 1);
        used.Add(nums[i]);
      }
    }

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
      Array.Sort(nums);
      var result = new List<IList<int>>();
      Explore(nums, 0, new List<int>(), result);
      return result;
    }
  }
}