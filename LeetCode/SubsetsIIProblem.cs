using System.Collections.Generic;

namespace LeetCode
{
  public class SubsetsIIProblem
  {
    private static void ExploreSubsets(int[] nums, int offset, List<int> snippet, List<IList<int>> result)
    {
      if (offset == nums.Length)
      {
        result.Add(new List<int>(snippet));
        return;
      }

      snippet.Add(nums[offset]);
      ExploreSubsets(nums, offset + 1, snippet, result);
      snippet.RemoveAt(snippet.Count - 1);
      ExploreSubsets(nums, offset + 1, snippet, result);
    }

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
      var result = new List<IList<int>>();
      ExploreSubsets(nums, 0, new List<int>(), result);
      return result;
    }
  }
}