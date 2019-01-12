using System;
using System.Diagnostics.Tracing;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace LeetCode
{
  public class LongestPalindromicSubstring
  {
    public string LongestPalindrome(string s)
    {
      if (s == null || s.Length < 2)
        return s;

      if (s.Length == 2)
        return IsPalindrome(s) ? s : s[0].ToString();

      string max = "";
      for (int i = s.Length - 1; i >= 0; i--)
      {
        var current1 = FindPalindrome1(s, i);
        var current2 = FindPalindrome2(s, i);

        if (current1 != null && current1.Length > max.Length)
        {
          max = current1;
        }

        if (current2 != null && current2.Length > max.Length)
        {
          max = current2;
        }
      }

      return max;
    }

    public string FindPalindrome1(string s, int middle)
    {
      int maxShift = middle > s.Length / 2 ? s.Length - middle : middle;

      for (int shift = maxShift; shift >= 0 ; shift--)
      {
        if (s.Length < middle - shift + shift * 2)
          continue;

        var str = s.Substring(middle - shift, shift * 2);
        if (IsPalindrome(str))
          return str;
      }

      return null;
    }

    public string FindPalindrome2(string s, int middle)
    {
      int maxShift = middle > s.Length / 2 ? s.Length - middle - 1 : middle;

      for (int shift = maxShift; shift >= 0; shift--)
      {
        if (s.Length < middle - shift + shift * 2 + 1)
          continue;

        var str = s.Substring(middle - shift, shift * 2 + 1);
        if (IsPalindrome(str))
          return str;
      }

      return null;
    }

    private bool IsPalindrome(string str)
    {
      for (int i = 0; i < str.Length / 2; i++)
      {
        if (str[i] != str[str.Length - i - 1])
          return false;
      }

      return true;
    }
  }
}