using System.Collections.Generic;

namespace LeetCode
{
  public class FindUniqueCharacterInAStringProblem
  {
    public int FirstUniqChar(string s)
    {
      if (s.Length == 1)
        return 0;

      var d = new Dictionary<char, int>();
      for (int i = 0; i < s.Length; i++)
      {
        if (d.ContainsKey(s[i]))
          d[s[i]]++;
        else
          d.Add(s[i], 1);
      }

      char c = ' ';
      foreach (var kvp in d)
      {
        if (kvp.Value == 1)
        {
          c = kvp.Key;
          break;
        }
      }

      return s.IndexOf(c);
    }
  }
}