using System;
using System.Collections.Generic;

namespace LeetCode
{
  public class ThreeSumProblem
  {
    private static void Backtrack(int[] nums, int offset, List<int> snippet, List<IList<int>> result)
    {
      if (snippet.Count == 3 && snippet[0] + snippet[1] + snippet[2] == 0)
      {
        result.Add(new List<int>(snippet));
        return;
      }

      for (int i = offset; i < nums.Length; i++)
      {
        

        snippet.Add(nums[i]);
        

        Backtrack(nums, i + 1, snippet, result);
        if (i > 0 && nums[i] == nums[i - 1])
        {
          continue;
        }

        snippet.RemoveAt(snippet.Count - 1);
      }
    }

    public IList<IList<int>> ThreeSum(int[] nums)
    {
      var result = new List<IList<int>>();
      Array.Sort(nums);
      Backtrack(nums, 0, new List<int>(), result);
      return result;
    }
  }
}