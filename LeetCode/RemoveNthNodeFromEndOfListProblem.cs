using System.Collections.Generic;

namespace LeetCode
{
  public class RemoveNthNodeFromEndOfListProblem
  {
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
      var list = new List<ListNode>();

      var current = head;
      while (current != null)
      {
        list.Add(current);
        current = current.next;
      }

      int prevIndex = list.Count - n - 1;
      int nextIndex = list.Count - n + 1;

      if (n == list.Count)
      {
        head = list.Count == 1 ? null : list[1];
        return head;
      }

      if (n == 1)
      {
        list[list.Count - 2].next = null;
        return head;
      }

      var prev = list[prevIndex];
      var next = list[nextIndex];
      prev.next = next;

      return head;
    }
  }
}