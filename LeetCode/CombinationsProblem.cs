using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LeetCode
{
  public class CombinationsProblem
  {
    private void Backtrack(int[] array, int from, List<IList<int>> result)
    {
      if (from == array.Length - 1)
      {
        result.Add(array.ToList());
        return;
      }

      for (int i = from; i < array.Length; i++)
      {
        Swap(array, from, i);
        Backtrack(array, from + 1, result);
        Swap(array, from, i);
      }
    }

    private void Swap(int[] array, int i, int j)
    {
      var tmp = array[i];
      array[i] = array[j];
      array[j] = tmp;
    }

    public IList<IList<int>> Combine(int n, int k)
    {
      var result = new List<IList<int>>();

      int[] array = new int[k];
      for (int i = 0; i < n; i++)
      {
        for (int j = i; j < i+k; j++)
        {
          array[j - i] = j + 1;
        }

        if (n % k == 0)
        {
          Backtrack(array, 0, result);
        }
      }

      
      return result;
    }
  }
}