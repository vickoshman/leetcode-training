using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
  public class CombinationSum3Problem
  {
    private void Helper(int k, int n, int from, int sumSoFar, List<int> soFar, List<IList<int>> result)
    {
      if (soFar.Count == k)
      {
        if (sumSoFar == n)
          result.Add(soFar.ToList());
        return;
      }

      for (int i = from; i < 10; i++)
      {
        if (sumSoFar + i > n)
          return;

        soFar.Add(i);
        sumSoFar += i;

        Helper(k, n, i + 1, sumSoFar, soFar, result);
        soFar.RemoveAt(soFar.Count - 1);
        sumSoFar -= i;
      }
    }

    public IList<IList<int>> CombinationSum3(int k, int n)
    {
      var result = new List<IList<int>>();

      Helper(k, n, 1, 0, new List<int>(), result);
      return result;
    }
  }
}