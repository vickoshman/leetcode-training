using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LeetCode
{
  public class GroupAnagramsProblem
  {
    public IList<IList<string>> GroupAnagrams2(string[] strs)
    {
      if (strs == null || strs.Length == 0)
        return null;

      var dictionary = new Dictionary<string, IList<string>>();
      for (int i = 0; i < strs.Length; i++)
      {
        var word = strs[i];
        var chars = strs[i].ToCharArray();
        Array.Sort(chars);

        var key = new string(chars);
        if (dictionary.ContainsKey(key))
          dictionary[key].Add(word);
        else
          dictionary.Add(key, new List<string> { word });
      }

      return dictionary.Values.ToList();
    }

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
      if (strs == null || strs.Length == 0)
        return null;

      var dictionary = new Dictionary<string, IList<string>>();
      for (int i = 0; i < strs.Length; i++)
      {
        var word = strs[i];

        var key = BuildSimpleKey(word);
        if (dictionary.ContainsKey(key))
          dictionary[key].Add(word);
        else
          dictionary.Add(key, new List<string> { word });
      }

      return dictionary.Values.ToList();
    }

    private string BuildSimpleKey(string s)
    {
      var arr = new int[26];
      foreach (var c in s)
        arr[c - 'a']++;

      var sb = new StringBuilder();
      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] == 0)
          continue;

        sb.AppendFormat("{0}:{1}|", i, arr[i]);
      }

      return sb.ToString();
    }

    private string BuildComplexKey(string s)
    {
      var charByCount = new Dictionary<int, int>();
      foreach (var c in s)
        if (charByCount.ContainsKey(c))
          charByCount[c]++;
        else
          charByCount.Add(c, 1);

      var sb = new StringBuilder();
      foreach (var kvp in charByCount.OrderBy(kvp => kvp.Key))
        sb.AppendFormat("{0}:{1}|", kvp.Key, kvp.Value);

      return sb.ToString();
    }
  }
}