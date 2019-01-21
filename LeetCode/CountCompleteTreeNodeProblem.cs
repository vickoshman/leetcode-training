using System.Security.AccessControl;
using LeetCode.Trees;

namespace LeetCode
{
  public class CountCompleteTreeNodeProblem
  {
    private int Count(TreeNode node)
    {
      int sum = 0;

      if (node != null)
        sum++;
      else
        return sum;

      if (node.left != null)
      {
        sum += Count(node.left);
      }

      if (node.right != null)
      {
        sum += Count(node.right);
      }

      return sum;
    }

    public int CountNodes(TreeNode root)
    {
      return Count(root);
    }
  }
}