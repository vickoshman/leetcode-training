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

    private void Traverse2(TreeNode root, List<int> result)
    {
      var stack = new Stack<TreeNode>();
      TreeNode lastVisited = null;
      var node = root;
      while (stack.Count != 0 || node != null)
      {
        if (node != null)
        {
          stack.Push(node);
          node = node.left;
        }
        else
        {
          var peekNode = stack.Peek();
          if (peekNode.right != null && lastVisited != peekNode.right)
          {
            node = peekNode.right;
          }
          else
          {
            result.Add(peekNode.val);
            lastVisited = stack.Pop();
          }
        }
      }
    }

    public IList<int> PostorderTraversal(TreeNode root)
    {
      var result = new List<int>();
      if (root == null)
        return result;

      Traverse2(root, result);
      return result;
    }
  }
}