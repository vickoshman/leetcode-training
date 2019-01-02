using System;
using System.Collections.Generic;

namespace LeetCode
{
  public class PalindromeNumberProblem
  {
    public bool IsPalindrome(int x)
    {
      if (x < 0)
        return false;

      if (x < 10)
        return true;

      var digits = new List<int>();
      
      while (x > 0)
      {
        var digit = x % 10;
        digits.Add(digit);
        x /= 10;
      }

      for (int i = 0; i < digits.Count; i++)
      {
        int first = digits[i];
        int last = digits[digits.Count - 1 - i];

        if (first != last)
          return false;
      }

      return true;
    }
  }
}