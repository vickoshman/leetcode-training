using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace LeetCode
{
  public class RomanToInteger
  {
    public int RomanToInt(string s)
    {
      var cor = new Dictionary<char, int>()
      {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
      };

      int total = 0;
      for (int i = 0; i < s.Length; i++)
      {
        var cur = cor[s[i]];
        if (i == 0)
        {
          total += cur;
          continue;
        }

        int prev = cor[s[i - 1]];
        if (prev == 1 && (cur == 5 || cur == 10))
        {
          total -= prev;
          total += cur - prev;
          continue;
        }

        if (prev == 10 && (cur == 50 || cur == 100))
        {
          total -= prev;
          total += cur - prev;
          continue;
        }

        if (prev == 100 && (cur == 500 || cur == 1000))
        {
          total -= prev;
          total += cur - prev;
          continue;
        }

        total += cur;
      }

      return total;
    }
  }
}