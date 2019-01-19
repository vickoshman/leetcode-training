using System.Globalization;

namespace LeetCode
{
  public class AddDigitsProblem
  {
    private int Add(int num)
    {
      int sum = 0;

      while (num > 9)
      {
        sum += num % 10;
        num /= 10;
      }

      sum += num;

      return sum > 9 ? Add(sum) : sum;
    }

    public int AddDigits(int num)
    {
      return Add(num);
    }
  }
}