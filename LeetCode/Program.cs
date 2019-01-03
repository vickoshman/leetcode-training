using System;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      var node = new ListNode(1);
      node.next = new ListNode(2);
      var cycleNode = node.next.next = new ListNode(3);

      node.next.next.next = cycleNode;

      var result = new LinkedListCycle().HasCycle2(node);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
