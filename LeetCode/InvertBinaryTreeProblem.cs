using LeetCode.Trees;

namespace LeetCode
{
  public class InvertBinaryTreeProblem
  {
    private void Invert(TreeNode node)
    {
      var tmp = node.left;
      node.left = node.right;
      node.right = tmp;

      if (node.left != null)
        Invert(node.left);

      if (node.right != null)
        Invert(node.right);
    }

    public TreeNode InvertTree(TreeNode root)
    {
      if (root == null)
        return root;
      Invert(root);
      return root;
    }
  }
}