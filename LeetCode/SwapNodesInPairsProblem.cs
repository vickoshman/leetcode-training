namespace LeetCode
{
  public class SwapNodesInPairsProblem
  {
    public ListNode SwapPairs(ListNode head)
    {
      if (head == null || head.next == null)
        return head;

      var slow = head;
      var fast = head.next;

      ListNode result = null;
      ListNode resultNode = null;

      int i = 0;
      while (fast != null)
      {
        slow.next = fast.next;
        fast.next = slow;

        if (result == null)
        {
          result = fast;
          resultNode = result;
        }
        else
        {
          resultNode.next.next = fast;
          resultNode = fast;
        }

        var next = slow.next;
        if (next == null)
          return result;

        slow = next;
        fast = next.next;
      }

      return result;
    }
  }
}