using System;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      var head = new ListNode(-10);
      head.next = new ListNode(-3);
      head.next.next = new ListNode(0);
      head.next.next.next = new ListNode(5);
      head.next.next.next.next = new ListNode(9);
      
      var result = new ConvertSortedListToBinarySearchTreeProblem().SortedListToBST(head);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
