using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LeetCode
{
  public class RestoreIpAddressesProblem
  {
    private int[] TryBuildParts(string s, int[] points)
    {
      int first = int.Parse(s.Substring(points[0] - 1, points[1] - points[0]));
      int second = int.Parse(s.Substring(points[1] - 1, points[2] - points[1]));
      int third = int.Parse(s.Substring(points[2] - 1, points[3] - points[2]));
      int forth = int.Parse(s.Substring(points[3] - 1, s.Length - points[3]));

      if (first > 255 || second > 255 || third > 255 || forth > 255)
        return null;

      return new int[] {first, second, third, forth};
    }

    public IList<string> RestoreIpAddresses(string s)
    {
      if (s == null || s.Length < 4)
        return null;

      var result = new List<string>();
      int[] points = new int[] {1, 2, 3, 4};

      for (int i = 0; i < s.Length; i++)
      {
        for (int j = 0; j < points.Length; j++)
        {
          for (int k = 0; k < s.Length; k++)
          {
            var shift = k + j + 1;
            if (shift + 3 >= s.Length)
              break;

            var parts = TryBuildParts(s, new int[] { shift, shift + 1, shift + 2, shift + 3 });
            if (parts != null)
              result.Add(string.Join(".", parts));
          }
        }
      }

      return result;
    }
  }
}