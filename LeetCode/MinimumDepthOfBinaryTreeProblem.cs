using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices.WindowsRuntime;
using LeetCode.Trees;
using Microsoft.Win32.SafeHandles;

namespace LeetCode
{
  public class MinimumDepthOfBinaryTreeProblem
  {
    public int GetMinPath(TreeNode root, int current)
    {
      current++;
      if (root.left == null && root.right == null)
        return current;

      int left = int.MaxValue;
      if (root.left != null)
        left = GetMinPath(root.left, current);

      int right = int.MaxValue;
      if (root.right != null)
        right = GetMinPath(root.right, current);

      return Math.Min(left, right);
    }
    
    public int MinDepth(TreeNode root)
    {
      if (root == null)
        return 0;

      if (root.left == null && root.right == null)
        return 1;

      return GetMinPath(root, 0);
    }
  }
}