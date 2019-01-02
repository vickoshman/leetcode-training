using System;
using System.Linq;

namespace LeetCode
{
  public class LongestSubstringWithoutRepeatingCharactersProblem
  {
    public int LengthOfLongestSubstring(string s)
    {
      int from = 0;
      int globalMax = 0;
      for (int ss = 0; ss < s.Length; ss++)
      {
        if (from == s.Length)
          return 0;

        int max = 0;
        var sub = new char[s.Length - from];
        for (int i = from; i < s.Length; i++)
        {
          var c = s[i];
          if (!sub.Contains(c))
          {
            sub[i - from] = c;
            max = Math.Max(max, i - from + 1);
            continue;
          }

          globalMax = Math.Max(max, globalMax);
          from++;
          break;
        }

        
        break;
      }

      return globalMax;
    }
  }
}