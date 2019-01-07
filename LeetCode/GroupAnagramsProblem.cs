using System.Collections.Generic;
using System.Globalization;

namespace LeetCode
{
  public class GroupAnagramsProblem
  {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
      if (strs == null || strs.Length == 0)
        return null;

      var result = new List<IList<string>>();

      var used = new HashSet<int>();
      for (int i = 0; i < strs.Length; i++)
      {
        if (!used.Add(i))
          continue;

        var current = new List<string>() {strs[i]};
        for (int j = i + 1; j < strs.Length; j++)
        {
          if (used.Contains(j))
            continue;

          if (IsAnagram(strs[i], strs[j]))
          {
            current.Add(strs[j]);
            used.Add(j);
          }
        }

        result.Add(current);
      }

      return result;
    }

    public bool IsAnagram(string str1, string str2)
    {
      if (str1.Length != str2.Length)
        return false;

      char[] chars = new char[26];
      for (int i = 0; i < str1.Length; i++)
      {
        chars[str1[i] - 'a']++;
        chars[str2[i] - 'a']--;
      }

      for (int i = 0; i < chars.Length; i++)
      {
        if (chars[i] != 0)
          return false;
      }

      return true;
    }
  }
}