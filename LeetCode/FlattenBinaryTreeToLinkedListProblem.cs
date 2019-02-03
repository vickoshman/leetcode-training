using LeetCode.Trees;

namespace LeetCode
{
  public class FlattenBinaryTreeToLinkedListProblem
  {
    private void Helper(TreeNode root, TreeNode current)
    {
      if (current == null)
        return;

      Helper(root.right, current.left);

      var tmp = root.right;
      root.right = current;
      current.right = tmp;
      current.left = null;

      Helper(root.right, current.right);
    }

    public void Flatten(TreeNode root)
    {
      Helper(root, root);
    }
  }
}