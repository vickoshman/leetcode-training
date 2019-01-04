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
        null, null
      };
      var result = new MergeKSortedListsProblem().MergeKLists(lists);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
