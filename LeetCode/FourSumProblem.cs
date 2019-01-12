using System;
using System.Collections.Generic;

namespace LeetCode
{
  public class FourSumProblem
  {
    private void Find(int[] nums, int start, int target, List<int> soFar, List<IList<int>> result)
    {
      if (soFar.Count == 4 && soFar[0] + soFar[1] + soFar[2] + soFar[3] == target)
      {
        result.Add(new List<int>(soFar));
        return;
      }

      for (int i = start; i < nums.Length - 1 && soFar.Count <= 4; i++)
      {
        soFar.Add(nums[i]);
        Find(nums, i+1, target, soFar, result);
        soFar.RemoveAt(soFar.Count - 1);
      }
    }

    public IList<IList<int>> FourSum(int[] nums, int target)
    {
      Array.Sort(nums);
      var result = new List<IList<int>>();

      for (int i = 0 ; i < nums.Length; i++)
        Find(nums, i, target, new List<int>(), result);
      return result;
    }
  }
}