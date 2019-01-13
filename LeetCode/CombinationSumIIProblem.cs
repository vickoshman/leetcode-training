using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace LeetCode
{
  public class CombinationSumIIProblem
  {
    private void Find(int[] candidates, int target, int offset, List<int> soFar, List<IList<int>> result)
    {
      if (target < 0 || offset > candidates.Length)
        return;

      if (target == 0)
      {
        result.Add(new List<int>(soFar));
      }

      int prev = -1;
      for (int i = offset; i < candidates.Length; i++)
      {
        if (prev != candidates[i])
        {
          soFar.Add(candidates[i]);
          Find(candidates, target - candidates[i], i + 1, soFar, result);
          soFar.RemoveAt(soFar.Count - 1);
          prev = candidates[i];
        }
      }
    }

    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
      if (candidates == null || candidates.Length == 0)
        return null;

      var result = new List<IList<int>>();

      Array.Sort(candidates);
      Find(candidates, target, 0, new List<int>(), result);

      return result;
    }
  }
}