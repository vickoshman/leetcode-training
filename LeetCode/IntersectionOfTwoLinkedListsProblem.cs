namespace LeetCode
{
  public class IntersectionOfTwoLinkedListsProblem
  {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
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