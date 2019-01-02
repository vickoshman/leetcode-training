using System.Net.Mail;

namespace LeetCode
{
  public class RemoveDuplicatesFromSortedListProblem
  {
    public class ListNode
    {
      public int val;
      public ListNode next;

      public ListNode(int x)
      {
        val = x;
      }
    }

    public ListNode DeleteDuplicates(ListNode head)
    {
      if (head == null || head.next == null)
        return head;

      var prevNode = head;
      var node = head.next;

      while (node != null)
      {
        if (prevNode.val == node.val)
        {
          prevNode.next = node.next;
          node = prevNode.next;
          continue;
        }

        prevNode = prevNode.next;
        node = node.next;
      }

      return head;
    }
  }
}