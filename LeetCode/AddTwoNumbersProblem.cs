namespace LeetCode
{
  public class AddTwoNumbersProblem
  {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
      int remainder = 0;

      var v1 = l1;
      var v2 = l2;
      int sum = 0;

      while (v1 != null || v2 != null)
      {
        int val1 = v1 == null ? 0 : v1.val;
        int val2 = v2 == null ? 0 : v2.val;

        sum *= 10;

        int tmp = val1 + val2;
        if (remainder > 0)
        {
          tmp += remainder;
          remainder = 0;
        }

        sum += tmp % 10;

        if (tmp > 9)
        {
          remainder += 1;
        }

        if (v1 != null)
          v1 = v1.next;

        if (v2 != null)
          v2 = v2.next;
      }

      return null;
    }
  }
}