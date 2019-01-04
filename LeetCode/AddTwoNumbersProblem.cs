using System.Runtime.Remoting;

namespace LeetCode
{
  public class AddTwoNumbersProblem
  {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
      var firstNode = l1;
      var secondNode = l2;

      int rem = 0;
      
      ListNode result = null;
      ListNode current = null;
      
      while (firstNode != null || secondNode != null || rem > 0)
      {
        int first = 0;
        if (firstNode != null)
        {
          first = firstNode.val;
          firstNode = firstNode.next;
        }
        
        int second = 0;
        if (secondNode != null)
        {
          second = secondNode.val;
          secondNode = secondNode.next;
        }

        var sum = first + second + rem;
        int currentValue = sum;
        if (sum > 9)
        {
          currentValue = sum % 10;
        }
        
        rem = sum / 10;

        if (result == null)
        {
          current = new ListNode(currentValue);
          result = current;
        }
        else
        {
          current.next = new ListNode(currentValue);
          current = current.next;
        }
      }

      return result;
    }
  }
}