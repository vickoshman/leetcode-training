using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LeetCode
{
  public class ThreeSumProblem
  {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
      var result = new List<IList<int>>();

      if (nums == null || nums.Length < 3)
        return result;

      Array.Sort(nums);

      int length = nums.Length;
      for (int i = 4; i < length; i++)
      {
        if (nums[i] == nums[i - 1] && nums[i] == nums[i - 2] && nums[i] == nums[i - 3] && nums[i] == nums[i - 4])
        {
          nums[i - 4] = nums[length - 1];
          length--;
        }
      }
      
      for (int i = 0; i < length; i++)
      {
        for (int j = i + 1; j < length; j++)
        {
          for (int k = j + 1; k < length; k++)
          {
            if (nums[i] + nums[j] + nums[k] != 0)
              continue;

            bool isDuplicate = false;
            
            foreach (var arr in result)
            {
              var list = new List<int> { nums[i], nums[j], nums[k] };
              if (IsDuplicate(arr, list))
              {
                isDuplicate = true;
                break;
              }
            }

            if (!isDuplicate)
              result.Add(new List<int> { nums[i], nums[j], nums[k] });
          }
        }
      }

      return result;
    }

    public bool IsDuplicate(IList<int> first, List<int> second)
    {
      second.Remove(first[0]);
      second.Remove(first[1]);
      second.Remove(first[2]);

      return second.Count == 0;
    }
  }
}