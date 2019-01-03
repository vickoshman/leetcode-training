using System.Collections.Generic;

namespace LeetCode
{
  public class LinkedListCycle
  {
    public bool HasCycle(ListNode head)
    {
      if (head == null || head.next == null)
        return false;
      
      var visited = new HashSet<ListNode>();

      var current = head;
      while (current != null)
      {
        if (visited.Add(current))
        {
          current = current.next;
          continue;
        }

        return true;
      }

      return false;
    }
    
    public bool HasCycle2(ListNode head)
    {
      if (head == null || head.next == null)
        return false;

      var slow = head;
      var fast = head.next;
      
      while (slow != null)
      {
        if (fast == null || fast.next == null)
          return false;

        if (fast == slow)
          return true;

        fast = fast.next.next;
        slow = slow.next;
      }

      return false;
    }
  }
}