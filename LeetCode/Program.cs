using System;
using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      new MergeSortedArrayProblem().Merge(new [] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
