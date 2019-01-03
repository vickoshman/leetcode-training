using System;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      var l1 = new ListNode(5);
      var l2 = new ListNode(5);
      
      var result = new AddTwoNumbersProblem().AddTwoNumbers(l1, l2);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
