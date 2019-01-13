using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace LeetCode
{
  public class CombinationSumIIProblem
  {
    private void Find(List<int> candidates, int target, int offset, HashSet<int> usedIndexes, List<int> soFar, HashSet<string> resultKeys, List<IList<int>> result)
    {
      if (target < 0 || offset > candidates.Count)
        return;

      if (target == 0)
      {
        var toAdd = new List<int>(soFar);
        toAdd.Sort();
        string sb = "";
        foreach (var key in toAdd)
          sb += ":" + key;

        if (resultKeys.Add(sb))
          result.Add(toAdd);

        return;
      }

      for (int i = offset; i < candidates.Count; i++)
      {
        if (usedIndexes.Contains(i))
          continue;

        soFar.Add(candidates[i]);
        usedIndexes.Add(i);

        Find(candidates, target - candidates[i], offset + 1, usedIndexes, soFar, resultKeys, result);
        soFar.RemoveAt(soFar.Count - 1);
        usedIndexes.Remove(i);
      }
    }

    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
      if (candidates == null || candidates.Length == 0)
        return null;

      var result = new List<IList<int>>();

      var array = new List<int>();
      for (int i = 0 ; i < candidates.Length; i++)
        if (candidates[i] <= target)
          array.Add(candidates[i]);

      array.Sort();
      Find(array, target, 0, new HashSet<int>(), new List<int>(), new HashSet<string>(), result);

      return result;
    }
  }
}