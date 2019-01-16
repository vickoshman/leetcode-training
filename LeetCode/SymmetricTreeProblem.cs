using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.Serialization.Formatters;
using LeetCode.Trees;

namespace LeetCode
{
  public class SymmetricTreeProblem
  {
    public bool IsSymmetric(TreeNode root)
    {
      if (root == null)
        return true;

      return Is(root.left, root.right);
    }

    private bool Is(TreeNode left, TreeNode right)
    {
      if (left == null || right == null)
        return left == right;

      if (left.val != right.val)
        return false;

      return Is(left.left, right.right) && Is(left.right, right.left);
    }
  }
}