using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LeetCode
{
  public class RestoreIpAddressesProblem
  {
    private static void RestoreIp(string s, int segment, int index, int[] path, List<string> result)
    {
      if (index == s.Length && segment == 4)
      {
        result.Add(path[0].ToString() + path[1].ToString() + path[2].ToString() + path[3].ToString());
        return;
      }

      if (index == s.Length || segment == 4)
        return;

      for (int len = 1; len <= 3 && index + len <= s.Length; len++)
      {
        int value = int.Parse(s.Substring(index, index + len));
        if (value > 255 || value >= 2 && s[index] == '0')
          break;

        path[segment] = value;
        RestoreIp(s, segment + 1, index + len, path, result);
        path[segment] = -1;
      }
    }

    public IList<string> RestoreIpAddresses(string s)
    {
      if (s == null || s.Length < 4)
        return null;

      var result = new List<string>();
      RestoreIp(s, 0, 0, new int[4], result);
      return result;
    }
  }
}