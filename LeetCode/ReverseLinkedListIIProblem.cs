namespace LeetCode
{
  public class ReverseLinkedListIIProblem
  {
    public ListNode ReverseBetween(ListNode head, int m, int n)
    {
      int i = 0;
      var current = head;
      ListNode started = null;
      ListNode next = head;

      while (next != null)
      {
        i++;

        if (i < m)
        {
          started = current;
          current = current.next;
          next = current.next;
          continue;
        }

        if (i == n)
        {
          return head;
        }

        started.next = current;

        current = next;
        next = next.next;
      }

      return head;
    }
  }
}