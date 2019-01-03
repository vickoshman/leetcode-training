namespace LeetCode
{
  public class LengthOfLastWordProblem
  {
    public int LengthOfLastWord(string s)
    {
      if (s == null || s.Length == 0)
        return 0;

      int length = 0;
      for (int i = s.Length - 1; i >= 0; i--)
      {
        if (s[i] != ' ')
          length++;
        else if (length > 0)
          return length;
      }

      return length;
    }
  }
}