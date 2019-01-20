using System.Collections.Generic;

namespace LeetCode
{
  public class LinkedListCycleProblem
  {
    public ListNode DetectCycle(ListNode head)
    {
      var set = new HashSet<ListNode>();
      var current = head;
      while (current != null)
      {
        if (!set.Add(current))
          return current;

        current = current.next;
      }

      return null;
    }
  }
}