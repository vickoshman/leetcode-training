using System.Collections.Generic;

namespace LeetCode
{
  public class RotateListProblem
  {
    public ListNode RotateRight(ListNode head, int k)
    {
      if (head == null || head.next == null)
        return head;

      var list = new List<ListNode>();
      var current = head;
      while (current != null)
      {
        list.Add(current);
        current = current.next;
      }

      if (k >= list.Count)
        k = k - (k / list.Count * list.Count);

      int pointer = list.Count - 1;
      for (int i = 0; i < k; i++)
      {
        if (pointer == 0)
        {
          list[0].next = list[1];
          list[list.Count - 1].next = null;
          pointer = list.Count - 1;
          head = list[0];
          continue;
        }

        var node = list[pointer];

        if (pointer == list.Count - 1)
        {
          node.next = list[0];
          list[pointer - 1].next = null;
          pointer--;
          head = node;
          continue;
        }

        node.next = list[pointer + 1];
        list[pointer - 1].next = null;
        head = node;
        pointer--;
      }

      return head;
    }
  }
}