using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
  public class PermuteUniqueProblem
  {
    private void Permute(int[] nums, int start, int end, List<IList<int>> result)
    {
      if (start == end)
      {
        foreach (var array in result)
        {
          bool isDuplicate = true;

          for (int i = 0; i < nums.Length; i++)
          {
            if (array[i] != nums[i])
            {
              isDuplicate = false;
              break;
            }
          }

          if (isDuplicate)
            return;
        }

        result.Add(nums.ToArray());
        return;
      }

      for (int i = start; i <= end; i++)
      {
        Swap(nums, start, i);
        Permute(nums, start + 1, end, result);
        Swap(nums, start, i);
      }
    }

    private void Swap(int[] nums, int i, int j)
    {
      var tmp = nums[i];
      nums[i] = nums[j];
      nums[j] = tmp;
    }

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
      if (nums == null)
        return null;

      var result = new List<IList<int>>();
      Permute(nums, 0, nums.Length - 1, result);
      return result;
    }
  }
}