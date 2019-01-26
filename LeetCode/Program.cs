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
      new SetMatrixZeroesProblem().SetZeroes(new int[,] {
        { 0 },  { 1 }
      });

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
