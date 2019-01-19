using System;
using System.Collections.Generic;

namespace LeetCode
{
  public class PermutationSequenceProblem
  {
    private void Generate(int n, int k, ref int current, HashSet<int> soFar, ref string result)
    {
      if (result != "")
        return;

      if (soFar.Count == n)
      {
        if (++current == k)
        {
          result = string.Join("", soFar);
          return;
        }

        return;
      }

      for (int i = 1; i <= n; i++)
      {
        if (soFar.Contains(i))
          continue;

        soFar.Add(i);
        Generate(n, k, ref current, soFar, ref result);
        soFar.Remove(i);
      }
    }

    public string GetPermutation(int n, int k)
    {
      string result = "";
      int i = 0;
      Generate(n, k, ref i, new HashSet<int>(), ref result);
      return result;
    }
  }
}