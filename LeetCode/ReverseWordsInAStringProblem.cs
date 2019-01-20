using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
  public class ReverseWordsInAStringProblem
  {
    public string ReverseWords(string s)
    {
      var stack = new Stack<string>();
      string word = "";
      for (int i = 0; i < s.Length; i++)
      {
        if (s[i] == ' ')
        {
          if (string.IsNullOrEmpty(word))
            continue;

          stack.Push(word);
          word = "";
          continue;
        }

        word += s[i];
      }

      if (!string.IsNullOrEmpty(word))
        stack.Push(word);

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