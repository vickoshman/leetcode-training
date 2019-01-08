using System;
using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      new WordSearchProblem().Exist(new[,]
      {
        {'a' }
      }, "ab");

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
