using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
  public class MergeKSortedListsProblem
  {
    public ListNode MergeKLists(ListNode[] lists)
    {
      if (lists == null || lists.Length == 0)
        return null;

      var lists1 = lists.ToList();

      ListNode result = null;
      ListNode currentResultNode = null;

      while (lists1.Count > 0)
      {
        int selectedList = 0;
        ListNode minNode = null;

        for (int i = 0; i < lists1.Count; i++)
        {
          if (currentResultNode != null && lists1[i] != null && currentResultNode.val == lists1[i].val)
          {
            minNode = lists1[i];
            selectedList = i;
            break;
          }

          if (minNode == null || (lists1[i] != null && lists1[i].val < minNode.val))
          {
            minNode = lists1[i];
            selectedList = i;
          }
        }

        if (lists1[selectedList] == null)
        {
          lists1.RemoveAt(selectedList);
          continue;
        }

        lists1[selectedList] = lists1[selectedList].next;
        if (lists1[selectedList] == null)
          lists1.RemoveAt(selectedList);

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