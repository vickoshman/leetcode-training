using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace LeetCode
{
  public class SetMatrixZeroesProblem
  {
    public void SetZeroes(int[,] matrix)
    {
      var set = new HashSet<int>();

      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1) && matrix.Rank > 1; j++)
        {
          if (matrix[i, j] == 0)
          {
            set.Add(i);
            set.Add(j);
            break;
          }
        }
      }

      foreach (var index in set)
      {
        for (int i = 0; i < matrix.GetLength(0); i++)
          matrix[i, index] = 0;

        for (int i = 0; i < matrix.GetLength(1) && matrix.Rank > 1; i++)
          matrix[index, i] = 0;
      }
    }
  }
}