using System;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      
      var lists = new ListNode[]
      {
        new ListNode(2), null, new ListNode(-1)
      };
      var result = new MergeKSortedListsProblem().MergeKLists(lists);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
