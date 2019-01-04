using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  public class ConvertSortedListToBinarySearchTreeProblem
  {
    public TreeNode BuildTree(ListNode head, int from, int to)
    {
      if (from > to)
        return null;

      var middle = (from + to) / 2;

      int i = 0;
      ListNode current = head;
      while (i++ < middle)
      {
        current = current.next;
      }

      var node = new TreeNode(current.val);
      node.left = BuildTree(head, from, middle - 1);
      node.right = BuildTree(head, middle + 1, to);
      return node;
    }
    
    public TreeNode BuildTree2(List<int> head, int from, int to)
    {
      if (from > to)
        return null;

      var middle = (from + to) / 2;

      var node = new TreeNode(head[middle]);
      node.left = BuildTree2(head, from, middle - 1);
      node.right = BuildTree2(head, middle + 1, to);
      return node;
    }
    
    public TreeNode SortedListToBST(ListNode head)
    {
      if (head == null)
        return null;

      int count = 0;
      ListNode current = head;
      while (current != null)
      {
        count++;
        current = current.next;
      }
      
      return BuildTree(head, 0, count - 1);
    }
    
    public TreeNode SortedListToBST2(ListNode head)
    {
      if (head == null)
        return null;

      var list = new List<int>();
      ListNode current = head;
      while (current != null)
      {
        list.Add(current.val);
        current = current.next;
      }
      
      return BuildTree2(list, 0, list.Count - 1);
    }
  }
}