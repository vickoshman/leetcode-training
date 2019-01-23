using System.Collections.Generic;
using System.Security.AccessControl;
using LeetCode.Trees;

namespace LeetCode
{
  public class BinaryTreeProorderTraversalProblem
  {
    private void Traverse(TreeNode node, List<int> result)
    {
      if (node == null)
        return;

      result.Add(node.val);
      if (node.left != null)
        Traverse(node.left, result);

      if (node.right != null)
        Traverse(node.right , result);
    }

    public IList<int> PreorderTraversal(TreeNode root)
    {
      var res = new List<int>();
      //Traverse(root, res);

      if (root == null)
        return res;

      var stack = new Stack<TreeNode>();
      stack.Push(root);

      while (stack.Count > 0)
      {
        var node = stack.Pop();
        res.Add(node.val);

        if (node.right != null)
          stack.Push(node.right);

        if (node.left != null)
          stack.Push(node.left);
      }

      return res;
    }
  }
}