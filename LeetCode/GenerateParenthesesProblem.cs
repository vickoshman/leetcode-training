using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace LeetCode
{
  public class GenerateParenthesesProblem
  {
    public void Backtrack(string current, int n, int open, int close, HashSet<string> result)
    {
      if (current.Length == n * 2)
      {
        result.Add(current);
        return;
      }

      if (open < n)
        Backtrack(current + "(", n, open + 1, close, result);

      if (close < open)
        Backtrack(current + ")", n, open, close + 1, result);
    }

    public IList<string> GenerateParenthesis(int n)
    {
      if (n == 0)
        return null;

      var result = new HashSet<string>();
      Backtrack("", n, 0, 0, result);
      return result.ToList();
    }
  }
}