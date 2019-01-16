namespace LeetCode
{
  public class ValidPalindromeProblem
  {
    public bool IsPalindrome(string s)
    {
      if (s == null || s.Length < 2)
        return true;

      int i = 0;
      int j = s.Length - 1;

      s = s.ToLower();
      while (i <= j)
      {
        var first = s[i];
        var second = s[j];

        if (char.IsLetterOrDigit(first))
        {
          if (char.IsLetterOrDigit(second))
          {
            if (first != second)
              return false;
            i++;
            j--;
          }
          else
          {
            j--;
          }
        }
        else
        {
          i++;
        }
      }

      return true;
    }
  }
}