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
      
      var result = new LongestSubstringWithoutRepeatingCharactersProblem().LengthOfLongestSubstring("aab");

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
