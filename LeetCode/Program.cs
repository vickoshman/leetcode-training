using System;
using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      var root = new TreeNode(10);
      root.left = new TreeNode(5);
      root.left.left = new TreeNode(3);
      root.left.left.left = new TreeNode(3);
      root.left.left.right = new TreeNode(-2);
      root.left.right = new TreeNode(2);
      root.left.right.right = new TreeNode(1);
      root.right = new TreeNode(-3);
      root.right.right = new TreeNode(11);

      new PathSumIIIProblem().PathSum(root, 8);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
