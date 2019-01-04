using System;
using System.Collections.Generic;
using LeetCode.Trees;
using Microsoft.Win32.SafeHandles;

namespace LeetCode
{
  public class IsBalancedTreeProblem
  {
    private int GetMaxHeight(TreeNode root)
    {
      return root == null ? 0 : (1 + Math.Max(GetMaxHeight(root.left), GetMaxHeight(root.right)));
    }
    
    public bool IsBalanced(TreeNode root)
    {
      return root == null || Math.Abs(GetMaxHeight(root.left) - GetMaxHeight(root.right)) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
  }
}