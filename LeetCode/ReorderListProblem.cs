using System.Collections.Generic;
using System.Security.Policy;

namespace LeetCode
{
  public class ReorderListProblem
  {
    public void ReorderList(ListNode head)
    {
      if (head == null || head.next == null)
        return;

      int count = 0;
      var current = head;
      while (current != null)
      {
        count++;
        current = current.next;
      }

      int index = 1;
      var prev = head;
      current = head.next;
      while (current != null && count %2 == 0 ? index < count / 2 : index < count / 2 + 1)
      {
        ListNode prevRight = null;
        var node = NodeAt(head, count - 1, ref prevRight);
        prevRight.next = node.next;

        prev.next = node;
        node.next = current;

        prev = current;
        current = current.next;
        index++;
      }
    }

    private ListNode NodeAt(ListNode head, int index, ref ListNode prev)
    {
      int count = 0;
      var current = head;
      while (count < index)
      {
        count++;
        prev = current;
        current = current.next;
      }

      return current;
    }

    private void Swap(ListNode prevNode1, ListNode node1, ListNode prevNode2, ListNode node2)
    {
      prevNode2.next = node1;

      if (prevNode1 != null)
        prevNode1.next = node2;

      var tmp = node1.next;
      node1.next = node2.next;
      node2.next = tmp;
    }
  }
}