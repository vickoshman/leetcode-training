using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LeetCode
{
  public class SingleNumberIIIProblem
  {
    public int[] SingleNumber(int[] nums)
    {
      var set = new HashSet<int>();

      for (int i = 0; i < nums.Length; i++)
      {
        if (!set.Add(nums[i]))
          set.Remove(nums[i]);
      }

      return set.ToArray();
    }
  }
}