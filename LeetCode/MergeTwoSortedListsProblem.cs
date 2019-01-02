namespace LeetCode
{
  public class MergeTwoSortedListsProblem
  {
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
    }

    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
      var cur1 = l1;
      var cur2 = l2;

      ListNode result = null;
      ListNode currentNode = null;

      while (true)
      {
        if (cur1 == null && cur2 == null)
          return result;

        if (cur1 == null || (cur2 != null && cur1.val > cur2.val))
        {
          if (result == null)
          {
            result = new ListNode(cur2.val);
            currentNode = result;
          }
          else
          {
            currentNode.next = new ListNode(cur2.val);
            currentNode = currentNode.next;
          }

          cur2 = cur2.next;
          continue;
        }

        if (cur2 == null || cur1.val <= cur2.val)
        {
          if (result == null)
          {
            result = new ListNode(cur1.val);
            currentNode = result;
          }
          else
          {
            currentNode.next = new ListNode(cur1.val);
            currentNode = currentNode.next;
          }

          cur1 = cur1.next;
        }
      }
    }
  }
}