using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LeetCode
{
  public class SingleNumberProblem
  {
    public int SingleNumber2(int[] nums)
    {
      var set = new HashSet<int>();
      for (int i = 0; i < nums.Length; i++)
      {
        if (!set.Add(nums[i]))
          set.Remove(nums[i]);
      }

      return set.ToArray()[0];
    }

    public int SingleNumber(int[] nums)
    {
      int res = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        res ^= nums[i];
      }

      return res;
    }
  }
}