using System.Collections.Generic;
using System.ComponentModel;

namespace LeetCode
{
  public class ValidParenthesesProblem
  {
    public bool IsValid(string s)
    {
      var stack = new Stack<char>();
      for (int i = 0; i < s.Length; i++)
      {
        if (stack.Count == 0 && IsClose(s[i]))
          return false;

        if (IsClose(s[i]))
        {
          if (!IsClosing(stack.Pop(), s[i]))
            return false;

          continue;
        }

        stack.Push(s[i]);
      }

      return stack.Count == 0;
    }

    public bool IsClosing(char one, char two)
    {
      if (one == '(' && two == ')')
        return true;

      if (one == '{' && two == '}')
        return true;

      if (one == '[' && two == ']')
        return true;

      return false;
    }

    public bool IsOpen(char c)
    {
      return c == '(' || c == '{' || c == '[';
    }

    public bool IsClose(char c)
    {
      return c == ')' || c == '}' || c == ']';
    }
  }
}