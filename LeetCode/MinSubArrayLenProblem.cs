using System;
using System.Runtime.Remoting;

namespace LeetCode
{
  public class MinSubArrayLenProblem
  {
    public int MinSubArrayLen(int s, int[] nums)
    {
      int sum = 0;
      int min = int.MaxValue;

      for (int i = 0; i < nums.Length; i++)
      {
        sum = 0;
        int current = 0;
        for (int j = i; j < nums.Length; j++)
        {
          current++;
          sum += nums[j];

          if (sum >= s)
          {
            min = Math.Min(current, min);
            break;
          }
        }
      }

      return min == int.MaxValue ? 0 : min;
    }
  }
}