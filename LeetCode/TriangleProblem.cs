using System;
using System.Collections.Generic;

namespace LeetCode
{
  public class TriangleProblem
  {
    private int MinSum(IList<IList<int>> triangle, int row, int column, int currentSum)
    {
      if (row == triangle.Count)
      {
        return currentSum;
      }

      currentSum += triangle[row][column];

      int one = int.MinValue;
      int two = int.MinValue;
      int three = int.MinValue;

      if (column == 0)
      {
        one = MinSum(triangle, row + 1, 0, currentSum);
        two = MinSum(triangle, row + 1, 1, currentSum);
        return Math.Min(one, two);
      }

      one = MinSum(triangle, row + 1, column, currentSum);
      two = MinSum(triangle, row + 1, column + 1, currentSum);
      return Math.Min(three, Math.Min(one, two));
    }

    public int MinimumTotal(IList<IList<int>> triangle)
    {
      return MinSum(triangle, 0, 0, 0);
    }
  }
}