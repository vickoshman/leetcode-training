namespace LeetCode
{
  public class DeleteNodeInALinkedListProblem
  {
    public void DeleteNode(ListNode node)
    {
      if (node == null || node.next == null)
        return;

      node.val = node.next.val;
      node.next = node.next.next;
    }
  }
}