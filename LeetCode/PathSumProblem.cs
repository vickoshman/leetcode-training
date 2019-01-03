using LeetCode.Trees;

namespace LeetCode
{
  public class PathSumProblem
  {
    public bool Impl(TreeNode node, int sum, int current)
    {
      current += node.val;
      if (node.left == null && node.right == null && current == sum)
        return true;

      if (node.left != null && Impl(node.left, sum, current))
        return true;

      if (node.right != null && Impl(node.right, sum, current))
        return true;
      
      return false;
    }
    
    public bool HasPathSum(TreeNode root, int sum)
    {
      if (root == null)
        return false;
      
      if (root.left == null && root.right == null && root.val == sum)
        return true;

      if (root.left != null && Impl(root.left, sum, root.val))
        return true;

      if (root.right != null && Impl(root.right, sum, root.val))
        return true;

      return false;
    }
  }
}