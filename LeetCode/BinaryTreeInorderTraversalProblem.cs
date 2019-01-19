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

    private void Traverse2(TreeNode root, IList<int> result)
    {
      var stack = new Stack<TreeNode>();
      var node = root;
      while (stack.Count > 0 || node != null)
      {
        if (node != null)
        {
          stack.Push(node);
          node = node.left;
        }
        else
        {
          node = stack.Pop();
          result.Add(node.val);
          node = node.right;
        }
      }
    }

    public IList<int> InorderTraversal(TreeNode root)
    {
      var result = new List<int>();

      if (root == null)
        return result;

      Traverse2(root, result);
      return result;
    }
  }
}