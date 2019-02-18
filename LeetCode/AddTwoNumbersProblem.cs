using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;

namespace LeetCode
{
  public class AddTwoNumbersProblem
  {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
      int rem = 0;
      ListNode res = null;
      var res1 = res;

      var cur1 = l1;
      var cur2 = l2;

      while (cur1 != null || cur2 != null)
      {
        int sum = cur1 == null ? 0 : cur1.val;
        sum += cur2 == null ? 0 : cur2.val;
        sum += rem;

        if (sum > 9)
        {
          rem = sum / 10;
          sum = sum % 10;
        }
        else
        {
          rem = 0;
        }

        if (res == null)
        {
          res = new ListNode(sum);
          res1 = res;
        }
        else
        {
          res1.next = new ListNode(sum);
          res1 = res1.next;
        }

        if (cur1 != null)
          cur1 = cur1.next;

        if (cur2 != null)
          cur2 = cur2.next;
      }

      if (rem == 0)
        return res;

      if (res1 == null)
        return new ListNode(rem);

      res1.next = new ListNode(rem);
      return res;
    }
  }
}