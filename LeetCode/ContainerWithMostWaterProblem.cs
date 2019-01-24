using System;
using System.Globalization;

namespace LeetCode
{
  public class ContainerWithMostWaterProblem
  {
    public int MaxArea(int[] height)
    {
      int max = 0;

      for (int i = 0; i < height.Length - 1; i++)
      {
        for (int j = i + 1; j < height.Length; j++)
        {
          int h = Math.Min(height[i], height[j]);
          int l = j - i;

          var area = h * l;
          if (area > max)
            max = area;
        }
      }

      return max;
    }
  }
}