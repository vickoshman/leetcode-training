using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  public class BinaryTreePostorderTraversalProblem
  {
    private void Traverse(TreeNode root, List<int> result)
    {
      if (root.left != null)
        Traverse(root.left, result);

      if (root.right != null)
        Traverse(root.right, result);

      result.Add(root.val);
    }

    public IList<int> PostorderTraversal(TreeNode root)
    {
      var result = new List<int>();
      if (root == null)
        return result;

      Traverse(root, result);
      return result;
    }
  }
}