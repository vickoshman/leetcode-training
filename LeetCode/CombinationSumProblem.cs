using System.Collections.Generic;

namespace LeetCode
{
  public class CombinationSumProblem
  {
    private void Permute(int[] candidates, int target, int offset, List<int> snippet, List<IList<int>> result)
    {
      if (target == 0)
      {
        result.Add(new List<int>(snippet));
        return;
      }

      for (int i = offset; i < candidates.Length; i++)
      {
        var value = candidates[i];
        if (value > target)
          continue;

        snippet.Add(value);
        Permute(candidates, target - value, i, snippet, result);
        snippet.RemoveAt(snippet.Count - 1);
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