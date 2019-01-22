using System.Globalization;

namespace LeetCode
{
  public class GuessNumberHigherOrLowerProblem
  {
    private int guess(int num)
    {
      if (num == 1702766719)
        return 0;

      if (num < 1702766719)
        return 1;

      return -1;
    }

    public int guessNumber(int n)
    {
      int from = 1;
      int to = n;

      while (from <= to)
      {
        int middle = from + (to - from) / 2;
        int res = guess(middle);
        if (res == 0)
          return middle;

        if (res == -1)
        {
          to = middle - 1;
        }
        else
        {
          from = middle + 1;
        }
      }

      return -1;
    }
  }
}