using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  public class BinaryTreePathsProblem
  {
    private void Traverse(TreeNode root, IList<string> result, string current)
    {
      current += root.val;

      if (root.left == null && root.right == null)
      {
        result.Add(current);
        return;
      }

      current += "->";

      if (root.left != null)
        Traverse(root.left, result, current);

      if (root.right != null)
        Traverse(root.right, result, current);
    }

    public IList<string> BinaryTreePaths(TreeNode root)
    {
      if (root == null)
        return new List<string>();

      var res = new List<string>();
      Traverse(root, res, "");
      return res;
    }
  }
}