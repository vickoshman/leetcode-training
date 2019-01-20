using System;
using System.Text;

namespace LeetCode
{
  public class AddBinaryProblem
  {
    public string AddBinary(string a, string b)
    {
      int length = Math.Max(a.Length, b.Length);
      var result = new StringBuilder();

      int cary = 0;
      for (int i = 0; i < length + 1; i++)
      {
        var first = i >= a.Length ? 0 : int.Parse(a[a.Length - i - 1].ToString());
        var second = i >= b.Length ? 0 : int.Parse(b[b.Length - i - 1].ToString());

        var sum = first + second + cary;
        if (sum == 0 || sum == 1)
        {
          if (sum == 1 || i != length)
            result.Insert(0, sum);
          cary = 0;
          continue;
        }

        if (sum == 2)
        {
          if (i != length)
            result.Insert(0, 0);

          cary = 1;
          continue;
        }

        result.Insert(0, 1);
      }

      return result.ToString();
    }
  }
}