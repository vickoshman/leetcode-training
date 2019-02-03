using System.Collections.Generic;

namespace LeetCode
{
  public class CountNumbersWithUniqueDigitsProblem
  {
    public int CountNumbersWithUniqueDigits(int n)
    {
      int from = 0;
      int to = 1;

      for (int i = 0; i < n; i++)
        to *= 10;

      int count = 0;

      for (int i = from; i < to; i++)
      {
        var hashSet = new HashSet<int>();
        int num = i;
        count++;
        while (num > 0)
        {
          var digit = num % 10;
          num /= 10;

          if (!hashSet.Add(digit))
          {
            count--;
            break;
          }
        }
      }

      return count;
    }
  }
}