using System.Collections.Generic;

namespace LeetCode
{
  public class IntersectionOfTwoLinkedListsProblem
  {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
      var set = new HashSet<ListNode>();
      var cur = headA;
      while (cur != null)
      {
        set.Add(cur);
        cur = cur.next;
      }

      cur = headB;
      while (cur != null)
      {
        if (!set.Add(cur))
          return cur;

        cur = cur.next;
      }

      return null;
    }

    public ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
    {
      var a = headA;
      var b = headB;

      while (a != null)
      {
        while (b != null)
        {
          if (a == b)
            return a;

          b = b.next;
        }

        a = a.next;
        b = headB;
      }

      return null;
    }
  }
}