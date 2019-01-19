using System;
using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      var head = new ListNode(3);
      head.next = new ListNode(5);
      new ReverseLinkedListIIProblem().ReverseBetween(head, 1, 2);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
