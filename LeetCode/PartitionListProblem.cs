namespace LeetCode
{
  public class PartitionListProblem
  {
    public ListNode Partition(ListNode head, int x)
    {
      if (head == null || head.next == null)
        return head;

      var current = head;
      ListNode xNode = null;

      while (current != null)
      {
        if (current.val == x)
        {
          xNode = current;
          break;
        }

        current = current.next;
      }

      current = head;
      ListNode nodeAfter  = xNode;
      while (nodeAfter != null)
      {
        var next = nodeAfter.next;
        if (next.val <= x)
        {
          var savedNext = nodeAfter.next == null ? null : nodeAfter.next.next;

          if (current.val > nodeAfter.next.val)
          {
            nodeAfter.next = current;

            break;
          }

          while (current != null && current.val < nodeAfter.next.val)
            current = current.next;

          var next2 = current.next;
          nodeAfter.next = next2;
          current.next = nodeAfter;

          nodeAfter.next = savedNext;
        }

        nodeAfter = nodeAfter.next;
      }

      return head;
    }
  }
}