using System;
using System.Net;

namespace LeetCode
{
  public class LongestPalindromicSubstring
  {
    public string LongestPalindrome(string s)
    {
      string max = "";
      for (int i = 1; i < s.Length; i++)
      {
        int shift = 1;
        while (i - shift >= 0 && i + shift < s.Length)
        {
          if (!IsPalindrome(s, i - shift, i + shift))
            break;
          
          int length = (i+shift) - (i-shift) + 1;
          if (length > max.Length)
            max = s.Substring(i-shift, length);
          
          shift++;
        }
      }

      return max;
    }

    private bool IsPalindrome(string s, int from, int to)
    {
      int shift = 0;
      while (shift <= to - from)
      {
        var c1 = s[from + shift];
        var c2 = s[to - shift];
        if (c1 != c2)
          return false;

        shift++;
      }

      return shift > 1;
    }
  }
}