using System.Text;

namespace HackerRank
{
  public class RepeatedStringProblem
  {
    static long repeatedString(string s, long n)
    {
      int num = 0;
      for (int i = 0; i < s.Length; i++)
        if (s[i] == 'a')
          num++;

      return num * n - (n-s.Length);
    }
  }
}