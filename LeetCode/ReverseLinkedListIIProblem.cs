using System.Collections.Generic;

namespace LeetCode
{
  public class ReverseLinkedListIIProblem
  {
    public ListNode ReverseBetween(ListNode head, int m, int n)
    {
      if (m == n)
        return head;

      Stack<ListNode> temp = new Stack<ListNode>();
      var current = head;

      int index = 1;
      ListNode toJoin = null;
      ListNode after = null;

      while (current != null)
      {
        if (index == m - 1)
          toJoin = current;

        if (index == n + 1)
        {
          after = current;
          break;
        }

        if (index >= m)
          temp.Push(current);

        current = current.next;
        index++;
      }

      current = toJoin;
      while (temp.Count != 0)
      {
        if (current == null)
        {
          current = temp.Pop();
          head = current;
          continue;
        }
        else
          current.next = temp.Pop();

        current = current.next;
      }

      if (current == null)
        return head;

      current.next = after;

      return head;
    }
  }
}