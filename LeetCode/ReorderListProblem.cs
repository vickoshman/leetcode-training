using System.Collections.Generic;

namespace LeetCode
{
  public class ReorderListProblem
  {
    public void ReorderList(ListNode head)
    {
      if (head == null)
        return;

      ListNode mid;
      var fast = head;
      var slow = head;

      while (fast != null && fast.next != null)
      {
        fast = fast.next.next;
        slow = slow.next;
      }

      mid = slow.next;
      slow.next = null;

      var l1 = head;

      var current = head;
      ListNode prev = null;
      while (current != null)
      {
        var nextNode = current.next;
        current.next = prev;
        prev = current;
        current = nextNode;
      }

      var l2 = prev;

      while (l2 != null)
      {
        var n1 = l1.next;
        var n2 = l2.next;

        l1.next = l2;
        l2.next = n1;

        l1 = n1;
        l2 = n2;
      }
    }
  }
}