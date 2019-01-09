using System.Collections.Generic;
using System.Globalization;

namespace LeetCode
{
  public class PascalsTriangleIIProblem
  {
    public IList<int> GetRow(int rowIndex)
    {
      if (rowIndex < 0)
        return null;

      if (rowIndex == 0)
        return new List<int>() { 1 };

      List<int> prev = null;
      var current = new List<int>() { 1, 1 };

      for (int i = 2; i < rowIndex + 1; i++)
      {
        prev = current;
        current = new List<int>();

        for (int j = 0; j <= i; j++)
        {
          if (j == 0 || j == i)
          {
            current.Add(1);
            continue;
          }

          current.Add(prev[j - 1] + prev[j]);
        }
      }

      return current;
    }
  }
}