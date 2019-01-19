using System.Diagnostics;
using LeetCode.Trees;

namespace LeetCode
{
  public class LowestCommonAncestorOfABinarySearchTreeProblem
  {
    private void Find(TreeNode root, TreeNode p, TreeNode q, int currentDepth, int lowestDepth, ref TreeNode current)
    {
      currentDepth++;

      if (root.left == p && root.right == q)
      {
        if (currentDepth > lowestDepth)
        {
          current = root;
          lowestDepth = currentDepth;
        }
      }

      if (root.left != null)
        Find(root.left, p, q, currentDepth, lowestDepth, ref current);

      if (root.right != null)
        Find(root.right, p, q, currentDepth, lowestDepth, ref current);
    }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
      if (root == null)
        return root;

      TreeNode lowest = null;
      Find(root, p, q, 0, 0, ref lowest);
      return lowest;
    }
  }
}