using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
  public class ThreeSumProblem
  {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
      var result = new List<IList<int>>();

      if (nums.Length < 3)
        return result;
      
      var list = nums.ToList();
      list.Sort();

      var prev = list[0];
      int met = 1;

      for (int i = 1; i < list.Count; i++)
      {
        if (list[i] != prev)
        {
          prev = list[i];
          met = 1;
          continue;
        }

        if (list[i] == prev && met > 2)
          list.RemoveAt(i);
      }

      var set = new HashSet<string>();

      for (int i = 0; i < list.Count; i++)
      {
        if (list[i] > 0)
          return result;

        if (list[i] + list[list.Count - 1] * 2 < 0)
          continue;

        for (int j = i + 1; j < list.Count; j++)
        {
          if (list[i] + list[j] > 0)
            break;

          var target = -(list[i] + list[j]);

          if (list[list.Count - 1] < target)
            break;

          var key = list[i] + ":" + list[j];
          if (set.Contains(key))
            continue;

          for (int k = j + 1; k < list.Count; k++)
          {
            if (list[k] > target)
              break;

            if (list[k] < target)
              continue;

            if (!set.Add(key))
              break;

            result.Add(new List<int> { list[i], list[j], list[k] });
            break;
          }
        }
      }

      return result;
    }
  }
}