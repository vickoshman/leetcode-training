using System.Collections.Generic;

namespace LeetCode
{
  public class IsIsomorphicStringsProblem
  {
    public bool IsIsomorphic(string s, string t)
    {
      var map = new Dictionary<char, char>();
      var set = new HashSet<char>();

      for (int i = 0; i < s.Length; i++)
      {
        if (map.ContainsKey(s[i]))
        {
          if (t[i] != map[s[i]])
            return false;
        }
        else
        {
          if (set.Contains(t[i]))
            return false;

          map.Add(s[i], t[i]);
          set.Add(t[i]);
        }
      }

      return true;
    }
  }
}