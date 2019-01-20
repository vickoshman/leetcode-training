using System.Collections.Generic;

namespace LeetCode
{
  public class SingleNumberIIProblem
  {
    public int SingleNumber(int[] nums)
    {
      var dic = new Dictionary<int, int>();
      for (int i = 0; i < nums.Length; i++)
      {
        if (dic.ContainsKey(nums[i]))
        {
          if (dic[nums[i]] == 2)
            dic.Remove(nums[i]);
          else
            dic[nums[i]]++;
        }
        else
          dic.Add(nums[i], 1);
      }

      foreach (var kvp in dic)
      {
        return kvp.Key;
      }

      return -1;
    }
  }
}