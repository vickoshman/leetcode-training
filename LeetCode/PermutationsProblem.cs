using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
  public class PermutationsProblem
  {
    private void Permute(int[] nums, int l, int r, IList<IList<int>> result)
    {
      if (l == r)
      {
        result.Add(nums.ToArray());
        return;
      }

      for (int i = l; i <= r; i++)
      {
        nums = Swap(nums, l, i);
        Permute(nums, l + 1, r, result);
        nums = Swap(nums, l, i);
      }
    }

    private int[] Swap(int[] nums, int i, int j)
    {
      var tmp = nums[i];
      nums[i] = nums[j];
      nums[j] = tmp;

      return nums;
    }

    public IList<IList<int>> Permute(int[] nums)
    {
      var result = new List<IList<int>>();
      if (nums == null || nums.Length == 0)
        return result;

      Permute(nums, 0, nums.Length - 1, result);
      return result;
    }
  }
}