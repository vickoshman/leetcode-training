using System.Net;

namespace LeetCode
{
  public class LongestPalindromicSubstring
  {
    public string LongestPalindrome(string s)
    {
      if (s == null)
        return s;
      
      string result = "";
      for (int i = 0; i < s.Length; i++)
      {
        for (int j = i; j < s.Length; j++)
        {
          if (IsPalindrome(s, i, j) && j - i > result.Length)
            result = s.Substring(i, s.Length - j);
        }
      }

      return result;
    }

    private bool IsPalindrome(string s, int from, int to)
    {
      for (int i = 0; i < to - from; i++)
      {
        from += i;
        to -= i;

        if (s[from] != s[to])
          return false;
      }

      return true;
    }
  }
}