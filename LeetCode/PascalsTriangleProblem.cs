using System.Collections.Generic;

namespace LeetCode
{
  public class PascalsTriangleProblem
  {
    public IList<IList<int>> Generate(int numRows)
    {
      var result = new List<IList<int>>();

      for (int i = 0; i < numRows; i++)
      {
        if (i == 0)
        {
          result.Add(new List<int>() { 1 });
          continue;
        }

        var list = new List<int>(i);
        for (int j = 0; j <= i; j++)
        {
          if (j == 0 || j == i)
          {
            list.Add(1);
            continue;
          }

          list.Add(result[i - 1][j - 1] + result[i - 1][j]);
        }

        result.Add(list);
      }

      return result;
    }
  }
}