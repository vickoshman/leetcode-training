using System.Collections.Generic;

namespace LeetCode
{
  public class MergeKSortedListsProblem
  {
    public ListNode MergeKLists(ListNode[] lists)
    {
      if (lists == null || lists.Length == 0)
        return null;

      var completed = new HashSet<int>();
      ListNode result = null;
      ListNode currentResultNode = null;

      while (completed.Count < lists.Length)
      {
        int selectedList = 0;
        ListNode minNode = null;

        for (int i = 0; i < lists.Length; i++)
        {
          if (completed.Contains(i))
            continue;

          if (lists[i] == null)
          {
            completed.Add(i);
            continue;
          }

          if (currentResultNode != null && currentResultNode.val == lists[i].val)
          {
            minNode = lists[i];
            selectedList = i;
            break;
          }

          if (minNode == null || lists[i].val < minNode.val)
          {
            minNode = lists[i];
            selectedList = i;
          }
        }

        if (lists[selectedList] == null)
        {
          completed.Add(selectedList);
          continue;
        }

        lists[selectedList] = lists[selectedList].next;
        if (lists[selectedList] == null)
          completed.Add(selectedList);

        if (result == null)
        {
          result = minNode;
          result.next = null;
          currentResultNode = result;
        }
        else
        {
          currentResultNode.next = minNode;
          currentResultNode = currentResultNode.next;
        }
      }

      return result;
    }
  }
}