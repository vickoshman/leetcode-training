using System;
using System.Text;

namespace LeetCode
{
  public class LargestNumberProblem
  {
    public string LargestNumber(int[] nums)
    {
      Array.Sort(nums, Comparison);
      StringBuilder res = new StringBuilder();
      for (int i = 0; i < nums.Length; i++)
        res.Append(nums[i]);

      return res.ToString();
    }

    private int Comparison(int i1, int i2)
    {
      var str1 = i1.ToString();
      var str2 = i2.ToString();

      for (int i = 0; i < Math.Min(str1.Length, str2.Length) - 1; i++)
      {
        if (str1[i] == str2[i])
          continue;

        if (int.Parse(str1[i].ToString()) > int.Parse(str2[i].ToString()))
          return int.Parse(str1);
        else
          return int.Parse(str2);
      }

      return str1.Length > str2.Length ? int.Parse(str2) : int.Parse(str1);
    }
  }
}