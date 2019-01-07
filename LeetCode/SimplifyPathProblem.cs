using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
  public class SimplifyPathProblem
  {
    public string SimplifyPath(string path)
    {
      if (path == null || path.Length == 0)
        return path;

      var length = path.Length;
      while (length != (path = path.Replace("//", "/")).Length)
      {
        length = path.Length;
      }

      var tokens = path.Split('/').ToList();
      var stack = new Stack<string>();

      for (int i = 0; i < tokens.Count; i++)
      {
        var token = tokens[i];
        if (token == "..")
        {
          if (stack.Count == 0)
            continue;

          var popped = stack.Pop();
          while (popped == "." && stack.Count > 0)
            popped = stack.Pop();
          continue;
        }
        else if (token == "." || token == "")
        {
          continue;
        }

        stack.Push(token);
      }

      var list = stack.ToList();
      list.Reverse();

      var result = "/" + string.Join("/", list).Replace("//", "/");
      result = result.TrimEnd('/');

      return result == "" ? "/" : result;
    }
  }
}