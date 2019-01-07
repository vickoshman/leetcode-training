using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;

namespace LeetCode
{
  public class CombinationsProblem
  {
    public void ExploreCombinations(int n, int k, int offset, List<int> snippet, List<IList<int>> result)
    {
      if (snippet.Count == k)
      {
        result.Add(new List<int>(snippet));
        return;
      }

      int spaceLeftInSnippet = k - snippet.Count;
      for (int i = offset; i <= n && spaceLeftInSnippet <= n - i + 1; i++)
      {
        snippet.Add(i);
        ExploreCombinations(n, k, i + 1, snippet, result);
        snippet.RemoveAt(snippet.Count - 1);
      }
    }

    public IList<IList<int>> Combine(int n, int k)
    {
      var result = new List<IList<int>>();
      ExploreCombinations(n, k, 1, new List<int>(), result);
      return result;
    }
  }
}