using System.Runtime.Serialization.Formatters;

namespace LeetCode
{
  public class PalindomeLinkedListProblem
  {
    public bool IsPalindrome(ListNode head)
    {
      int count = 0;

      var current = head;
      while (current != null)
      {
        count++;
        current = current.next;
      }

      int middle = count / 2;
      int index = 0;

      var right = head;
      while (index++ != middle)
      {
        right = right.next;
      }

      if (count % 2 != 0)
        right = right.next;

      while (right != null)
      {
        if (!Equal(head, --index, right))
          return false;

        right = right.next;
      }

      return true;
    }

    private bool Equal(ListNode head, int index, ListNode right)
    {
      int i = 0;
      var current = head;

      while (++i != index)
        current = current.next;

      return current.val == right.val;
    }
  }
}