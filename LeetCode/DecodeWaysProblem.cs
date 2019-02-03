using System.Linq;
using System.Xml.Serialization;

namespace LeetCode
{
  public class DecodeWaysProblem
  {
    private void Count(string s, int index, ref int sum)
    {
      if (index >= s.Length)
      {
        sum++;
        return;
      }

      int digit1 = s[index] - '0';

      if (digit1 == 0)
        return;

      Count(s, index + 1, ref sum);

      if (index >= s.Length - 1 || digit1 >= 3)
        return;

      int digit2 = s[index + 1] - '0';
      digit1 *= 10;
      digit1 += digit2;
      if (digit1 > 0 && digit1 <= 26)
        Count(s, index + 2, ref sum);
    }

    public int NumDecodings(string s)
    {
      int sum = 0;
      Count(s, 0, ref sum);

      return sum;
    }
  }
}