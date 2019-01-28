using System;

namespace HackerRank
{
  public class HighestValuePolinfromeProblem
  {
    static string highestValuePalindrome(string s, int n, int k)
    {
      var chars = s.ToCharArray();
      int changesRequired = 0;
      for (int i = 0; i < chars.Length / 2; i++)
      {
        var left = chars[i];
        var right = chars[chars.Length - i - 1];

        if (left != right)
          changesRequired++;
      }

      if (changesRequired > k)
        return "-1";

      var extra = k - changesRequired;

      for (int i = 0; i < chars.Length / 2; i++)
      {
        var left = chars[i];
        var right = chars[chars.Length - i - 1];

        if (left == right)
        {
          if (extra >= 2)
          {
            if (left != '9')
            {
              chars[i] = '9';
              extra--;
            }

            if (right != '9')
            {
              chars[chars.Length - i - 1] = '9';
              extra--;
            }
          }

          continue;
        }

        char max = chars[i] > chars[chars.Length - i - 1] ? chars[i] : chars[chars.Length - i - 1];
        if (max == '9')
        {
          chars[i] = '9';
          chars[chars.Length - i - 1] = '9';
          changesRequired--;
          continue;
        }

        if (extra >= 1)
        {
          chars[i] = '9';
          chars[chars.Length - i - 1] = '9';
          extra--;
          changesRequired--;
          continue;
        }

        chars[i] = max;
        chars[chars.Length - i - 1] = max;
        changesRequired--;
      }

      if (chars.Length % 2 != 0 && chars[chars.Length / 2] != '9' && extra > 0 || changesRequired > 0)
        chars[chars.Length / 2] = '9';


      return new string(chars);
    }
  }
}