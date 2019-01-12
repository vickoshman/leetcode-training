using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;

namespace LeetCode
{
  public class GroupAnagramsProblem
  {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
      if (strs == null || strs.Length == 0)
        return null;

      var anagramsByLength = new Dictionary<int, List<IList<string>>>();

      for (int i = 0; i < strs.Length; i++)
      {
        var currentLength = strs[i].Length;

        if (!anagramsByLength.ContainsKey(currentLength))
        {
          var group = new List<IList<string>>();
          group.Add(new List<string> { strs[i] });

          anagramsByLength.Add(currentLength, group);
          continue;
        }

        IList<string> toAdd = null;
        foreach (var group in anagramsByLength[currentLength])
        {
          if (IsAnagram(strs[i], @group[0]))
          {
            toAdd = @group;
            break;
          }
        }

        if (toAdd == null)
        {
          anagramsByLength[currentLength].Add(new List<string>() { strs[i] });
        }
        else
        {
          toAdd.Add(strs[i]);
        }
      }

      var result = new List<IList<string>>();

      foreach (var kvp in anagramsByLength)
        result.AddRange(kvp.Value);

      return result;
    }

    private bool IsAnagram(string s, string s1)
    {
      var set = new List<char>();
      foreach (char c in s)
        set.Add(c);
      foreach (char c in s1)
      {
        set.Remove(c);
      }

      return set.Count == 0;
    }
  }
}