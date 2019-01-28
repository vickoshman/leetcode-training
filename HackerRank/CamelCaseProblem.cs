namespace HackerRank
{
  public class CamelCaseProblem
  {
    static int camelcase(string s)
    {
      int count = 0;
      for (int i = 0; i < s.Length; i++)
      {
        if (char.IsUpper(s[i]))
          count++;
      }

      return count - 1;
    }
  }
}