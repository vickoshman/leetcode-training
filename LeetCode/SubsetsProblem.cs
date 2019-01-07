using System.Collections.Generic;

namespace LeetCode
{
  public class SubsetsProblem
  {
    public IList<IList<int>> Subsets(int[] nums)
    {
      var result = new List<IList<int>>();
      Generate(nums, 0, new List<int>(), result);
      return result;
    }

    private static void Generate(int[] nums, int decisionPoint, List<int> selectedSoFar, List<IList<int>> powerSet)
    {
      if (decisionPoint == nums.Length)
      {
        powerSet.Add(new List<int>(selectedSoFar));
        return;
      }

      selectedSoFar.Add(nums[decisionPoint]);
      Generate(nums, decisionPoint + 1, selectedSoFar, powerSet);
      selectedSoFar.RemoveAt(selectedSoFar.Count - 1);
      Generate(nums, decisionPoint + 1, selectedSoFar, powerSet);
    }
  }
}