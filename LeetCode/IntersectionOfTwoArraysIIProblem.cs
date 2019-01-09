using System;
using System.Collections.Generic;

namespace LeetCode
{
  public class IntersectionOfTwoArraysIIProblem
  {
    public int[] Intersect(int[] nums1, int[] nums2)
    {
      Array.Sort(nums1);
      Array.Sort(nums2);

      var result = new List<int>();
      int i = 0;
      int j = 0;

      while (i < nums1.Length && j < nums2.Length)
      {
        if (nums1[i] == nums2[j])
        {
          result.Add(nums1[i]);
          i++;
          j++;
          continue;
        }

        if (nums1[i] > nums2[j])
          j++;
        else
          i++;
      }

      return result.ToArray();
    }
  }
}