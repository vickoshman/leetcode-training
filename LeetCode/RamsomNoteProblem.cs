using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
  public class RamsomNoteProblem
  {
    public bool CanConstruct(string ransomNote, string magazine)
    {
      if (ransomNote.Length > magazine.Length)
        return false;

      var list = magazine.ToCharArray().ToList();
      for (int i = 0; i < ransomNote.Length; i++)
      {
        if (!list.Remove(ransomNote[i]))
          return false;
      }

      return true;
    }
  }
}