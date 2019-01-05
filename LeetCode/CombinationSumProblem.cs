using System.Collections.Generic;

namespace LeetCode
{
  public class CombinationSumProblem
  {
    private void Permute(int[] candidates, int target, int start, List<int> current, List<IList<int>> result)
    {
      if (target <= 0)
        return;

      if (target == 0)
      {
        result.Add(current);
        return;
      }

      for (int i = start; i < candidates.Length; i++)
      {
        current.Add(candidates[i]);
        Permute(candidates, target - candidates[i], i, current, result);
        current.RemoveAt(current.Count - 1);
      }
    }

    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
      if (candidates == null)
        return null;

      var result = new List<IList<int>>();
      Permute(candidates, target, 0, new List<int>(), result);
      return result;
    }
  }
}