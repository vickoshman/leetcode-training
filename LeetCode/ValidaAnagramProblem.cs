using System.Linq;

namespace LeetCode
{
  public class ValidaAnagramProblem
  {
    public bool IsAnagram(string s, string t)
    {
      if (s == null || t == null)
        return false;

      if (s.Length != t.Length)
        return false;

      var list = s.ToCharArray().ToList();
      foreach (var c in t)
      {
        if (!list.Remove(c))
          return false;
      }

      return true;
    }
  }
}