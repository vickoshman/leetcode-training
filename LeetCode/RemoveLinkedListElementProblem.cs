namespace LeetCode
{
  public class RemoveLinkedListElementProblem
  {
    public ListNode RemoveElements(ListNode head, int val)
    {
      if (head == null)
        return null;

      var cur = head;
      ListNode prev = null;

      while (cur != null)
      {
        if (cur.val == val)
        {
          if (prev == null)
          {
            head = cur.next;
            cur = head;
            continue;
          }
          else
          {
            prev.next = cur.next;
            cur = cur.next;
            continue;
          }
        }

        prev = cur;
        cur = cur.next;
      }

      return head;
    }
  }
}