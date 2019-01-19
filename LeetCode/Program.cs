using System;
using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      var head = new ListNode(1);
      head.next = new ListNode(2);

      new PalindomeLinkedListProblem().IsPalindrome(head);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
