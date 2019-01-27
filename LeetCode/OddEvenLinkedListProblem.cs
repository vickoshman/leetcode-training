using System.Data.SqlTypes;

namespace LeetCode
{
  public class OddEvenLinkedListProblem
  {
    public ListNode OddEvenList(ListNode head)
    {
      if (head == null || head.next == null)
        return head;

      var odd = head;
      var result = new ListNode(odd.val);

      var current = result;

      if (odd.next != null)
        odd = odd.next.next;
      else
        odd = null;

      while (odd != null)
      {
        current.next = new ListNode(odd.val);
        current = current.next;

        if (odd.next == null)
          break;

        odd = odd.next.next;
      }

      var even = head.next;
      while (even != null)
      {
        current.next = new ListNode(even.val);
        current = current.next;

        if (even.next == null)
          break;

        even = even.next.next;
      }

      return result;
    }
  }
}