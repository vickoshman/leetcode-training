using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  public class BinaryTreeLevelOrderTraversalProblem
  {
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
      if (root == null)
        return new List<IList<int>>();

      var result = new List<IList<int>>();
      var queue = new Queue<TreeNode>();
      queue.Enqueue(root);

      while (queue.Count != 0)
      {
        List<int> list = new List<int>();
        int size = queue.Count;
        while (size > 0)
        {
          var node = queue.Dequeue();

          if (node.left != null)
            queue.Enqueue(node.left);

          if (node.right != null)
            queue.Enqueue(node.right);

          list.Add(node.val);
          size--;
        }

        if (list.Count > 0)
          result.Add(list);
      }

      return result;
    }
  }
}