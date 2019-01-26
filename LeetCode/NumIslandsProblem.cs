using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeetCode
{
  public class NumIslandsProblem
  {
    public int NumIslands(char[,] grid)
    {
      int islands = 0;

      for (int i = 0; i < grid.GetLength(0); i++)
        for (int j = 0; j < grid.GetLength(1); j++)
        {
          if (grid[i, j] == '1')
            islands++;

          Traverse(grid, i, j);
        }

      return islands;
    }

    private void Traverse(char[,] grid, int i, int j)
    {
      if (i < 0 || i >= grid.GetLength(0))
        return;

      if (j < 0 || j >= grid.GetLength(1))
        return;

      if (grid[i, j] == '0' || grid[i, j] == 'x')
        return;

      grid[i, j] = 'x';

      Traverse(grid, i - 1, j);
      Traverse(grid, i + 1, j);

      Traverse(grid, i, j - 1);
      Traverse(grid, i, j + 1);
    }
  }
}