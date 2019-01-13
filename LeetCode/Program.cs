using System;
using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      var result = new CombinationSumIIProblem().CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
