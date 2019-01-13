namespace LeetCode
{
  public class FirstBadVersionProblem
  {
    private bool IsBadVersion(int num)
    {
      return num >= 4;
    }

    public int FirstBadVersion(int n)
    {
      int start = 1;
      int end = n;

      if (start == end)
        return start;

      while (true)
      {
        if (start > end)
          return start;

        int middle = start + (end - start) / 2;
        if (IsBadVersion(middle))
        {
          end = middle - 1;
          continue;
        }

        start = middle + 1;
      }
    }
  }
}