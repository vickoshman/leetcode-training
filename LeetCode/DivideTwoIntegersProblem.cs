namespace LeetCode
{
  public class DivideTwoIntegersProblem
  {
    public int Divide(int dividend, int divisor)
    {
      bool returnNegative = dividend < 0 || divisor < 0 && (dividend > 0 || divisor > 0);
      dividend = dividend < 0 ? -dividend : dividend;
      divisor = divisor < 0 ? -divisor : divisor;

      for (int i = 0; i < divisor - 1; i++)
      {
        dividend -= divisor;
      }

      if (divisor > dividend)
        dividend = divisor;

      return returnNegative ? -dividend : dividend;
    }
  }
}