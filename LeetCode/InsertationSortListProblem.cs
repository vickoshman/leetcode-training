namespace LeetCode
{
  public class InsertationSortListProblem
  {
    public ListNode InsertionSortList(ListNode head)
    {
      if (head == null || head.next == null)
        return head;

      var prev = head;
      var current = head.next;
      ListNode result = new ListNode(head.val);

      while (current != null)
      {
        var node = new ListNode(current.val);

        prev.next = current.next;
        Helper(ref result, node);
        prev = current;
        current = current.next;
      }

      return result;
    }

    private void Helper(ref ListNode result, ListNode node)
    {
      var current = result;
      ListNode prev = null;

      while (current != null)
      {
        if (node.val < current.val)
        {
          if (prev == null)
          {
            node.next = result;
            result = node;
            return;
          }

          prev.next = node;
          node.next = current;
          return;
        }

        prev = current;
        current = current.next;
      }

      prev.next = node;
      node.next = null;
    }
  }
}