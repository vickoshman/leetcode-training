using System.Collections.Generic;

namespace LeetCode
{
  public class ContainsDuplicateProblem
  {
    public bool ContainsDuplicate(int[] nums)
    {
      var set = new HashSet<int>();
      foreach (var num in nums)
      {
        if (!set.Add(num))
          return true;
      }

      return false;
    }
  }
}