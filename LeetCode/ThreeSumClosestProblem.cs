using System;

namespace LeetCode
{
  public class ThreeSumClosestProblem
  {
    public int ThreeSumClosest(int[] nums, int target)
    {
      int closest = nums[0] + nums[1] + nums[2];

      for (int i = 0; i < nums.Length; i++)
      {
        for (int j = i + 1; j < nums.Length; j++)
        {
          for (int k = j + 1; k < nums.Length; k++)
          {
            int sum = nums[i] + nums[j] + nums[k];
            int prevDif = Math.Abs(closest - target);
            int currentDif = Math.Abs(sum - target);

            if (currentDif == 0)
              return sum;

            if (currentDif < prevDif)
              closest = sum;
          }
        }
      }

      return closest;
    }
  }
}