using System.Diagnostics;

namespace LeetCode
{
  public class ReverseVowelsProblem
  {
    private bool IsVowel(string c)
    {
      c = c.ToLower();
      return c == "e" || c == "u" || c == "i" || c == "o" || c == "a";
    }

    public string ReverseVowels(string s)
    {
      if (s == null || s.Length < 2)
        return s;

      int i = 0;
      int j = s.Length - 1;

      var chars = s.ToCharArray();
      while (i < j)
      {
        if (IsVowel(chars[i].ToString()))
        {
          while (j > i)
          {
            if (IsVowel(chars[j].ToString()))
            {
              var c = chars[i];
              chars[i] = chars[j];
              chars[j] = c;

              j--;

              break;
            }

            j--;
          }
        }

        i++;
      }

      return new string(chars);
    }
  }
}