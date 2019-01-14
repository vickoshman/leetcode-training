using System.CodeDom;
using System.Collections.Generic;

namespace LeetCode
{
  public class FindTheDifferenceProblem
  {
    public char FindTheDifference(string s, string t)
    {
      var dic = new Dictionary<char, int>();
      foreach (var c in s)
      {
        if (dic.ContainsKey(c))
          dic[c]++;
        else
          dic.Add(c, 1);
      }

      foreach (var c in t)
      {
        if (!dic.ContainsKey(c))
          return c;

        dic[c]--;
        if (dic[c] < 0)
          return c;
      }

      return ' ';
    }
  }
}