using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeetCode
{
  public class NumIslandsProblem
  {
    public int NumIslands(char[,] grid)
    {
      var visited = new HashSet<string>();
      int islands = 0;

      for (int i = 0; i < grid.GetLength(0); i++)
        for (int j = 0; j < grid.GetLength(1); j++)
        {
          int before = visited.Count;
          Traverse(grid, i, j, visited);
          if (before != visited.Count)
            islands++;
        }

      return islands;
    }

    private void Traverse(char[,] grid, int i, int j, HashSet<string> visited)
    {
      if (i < 0 || i >= grid.GetLength(0))
        return;

      if (j < 0 || j >= grid.GetLength(1))
        return;

      if (grid[i, j] == '0')
        return;

      if (!visited.Add(i + ":" + j))
        return;

      Traverse(grid, i - 1, j, visited);
      Traverse(grid, i + 1, j, visited);

      Traverse(grid, i, j - 1, visited);
      Traverse(grid, i, j + 1, visited);
    }
  }
}