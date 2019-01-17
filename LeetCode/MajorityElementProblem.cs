using System.Collections.Generic;

namespace LeetCode
{
  public class MajorityElementProblem
  {
    public int MajorityElement(int[] nums)
    {
      var dic = new Dictionary<int, int>();
      for (int i = 0; i < nums.Length; i++)
      {
        if (dic.ContainsKey(nums[i]))
          dic[nums[i]]++;
        else
          dic.Add(nums[i], 1);
      }

      foreach (var kvp in dic)
      {
        if (kvp.Value > nums.Length / 2)
          return kvp.Key;
      }

      return 0;
    }
  }
}