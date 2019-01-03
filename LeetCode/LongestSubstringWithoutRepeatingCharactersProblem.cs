using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
  public class LongestSubstringWithoutRepeatingCharactersProblem
  {
    public int LengthOfLongestSubstring(string s)
    {
      if (s == null)
        return 0;

      if (s.Length == 1)
        return 1;
      
      HashSet<char> longest = null;
      HashSet<char> current = null;
      
      for (int i = 0; i < s.Length; i++)
      {
        current = new HashSet<char>();
        for (int j = i; j < s.Length; j++)
        {
          if (!current.Add(s[j]))
          {
            break;
          }
          
          if (longest == null || longest.Count < current.Count)
            longest = current;
        }
      }

      return longest == null ? 0 : longest.Count;
    }
  }
}