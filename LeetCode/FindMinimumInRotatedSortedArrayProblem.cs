using System;

namespace LeetCode
{
  public class FindMinimumInRotatedSortedArrayProblem
  {
    public int FindMin(int[] nums)
    {
      if (nums.Length == 1)
        return nums[0];

      int left = 0;
      int right = nums.Length - 1;

      if (nums[right] > nums[0])
        return nums[0];

      while (left <= right)
      {
        int mid = left + (right - left) / 2;

        if (nums[mid] > nums[mid + 1])
          return nums[mid + 1];

        if (nums[mid - 1] > nums[mid])
          return nums[mid];

        if (nums[0] < nums[mid])
        {
          left = mid + 1;
        }
        else if (nums[0] > nums[mid])
        {
          right = mid - 1;
        }
      }

      return - 1;
    }
  }
}