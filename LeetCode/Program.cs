using System;
using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      new SimplifyPathProblem().SimplifyPath("/a/./b///../c/../././../d/..//../e/./f/./g/././//.//h///././/..///");

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
