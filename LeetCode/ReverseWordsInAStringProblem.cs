using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
  public class ReverseWordsInAStringProblem
  {
    public string ReverseWords(string s)
    {
      var stack = new Stack<string>();
      var word = new StringBuilder();
      for (int i = 0; i < s.Length; i++)
      {
        if (s[i] == ' ')
        {
          if (word.Length == 0)
            continue;

          stack.Push(word.ToString());
          word.Clear();
          continue;
        }

        word.Append(s[i]);
      }

      if (word.Length != 0)
        stack.Push(word.ToString());

      var result = new StringBuilder();

      while (stack.Count > 0)
      {
        result.Append(stack.Pop());
        if (stack.Count == 0)
          return result.ToString();

        result.Append(" ");
      }

      return "";
    }
  }
}