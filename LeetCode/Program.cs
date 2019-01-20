using System;
using System.Collections;
using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      var triangle = new List<IList<int>>()
      {
        new List<int>{ -1 },
        new List<int>{ 2, 3 },
        new List<int>{ 1, -1, -3 },
      };
      new TriangleProblem().MinimumTotal(triangle);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
