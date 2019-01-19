using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  public class BinaryTreeInorderTraversalProblem
  {
    private void Traverse(TreeNode root, IList<int> result)
    {
      if (root.left != null)
        Traverse(root.left, result);

      result.Add(root.val);

      if (root.right != null)
        Traverse(root.right, result);
    }

    public IList<int> InorderTraversal(TreeNode root)
    {
      var result = new List<int>();

      if (root == null)
        return result;

      Traverse(root, result);
      return result;
    }
  }
}