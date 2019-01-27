using System;
using System.Collections;
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
      head.next.next = new ListNode(3);
      head.next.next.next = new ListNode(4);
      new ReorderListProblem().ReorderList(head);
      Console.ReadKey();
    }
  }
}
