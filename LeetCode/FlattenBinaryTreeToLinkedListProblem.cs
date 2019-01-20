using LeetCode.Trees;

namespace LeetCode
{
  public class FlattenBinaryTreeToLinkedListProblem
  {
    private void Helper(TreeNode node, ref ListNode list)
    {
      if (list == null)
        list = new ListNode(node.val);
      else
        list.next = new ListNode(node.val);

      if (node.left != null)
        Helper(node.left, ref list);

      if (node.right != null)
        Helper(node.right, ref list);
    }

    public void Flatten(TreeNode root)
    {
      ListNode list = null;
      Helper(root, ref list);

      var current = list.next;
      while (current != null)
      {
        root.right = new TreeNode(current.val);
        current = current.next;
      }
    }
  }
}