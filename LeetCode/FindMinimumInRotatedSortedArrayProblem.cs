namespace LeetCode
{
  public class FindMinimumInRotatedSortedArrayProblem
  {
    public int FindMin(int[] nums)
    {
      int min = nums[0];
      bool skipped = false;
      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] < min)
        {
          min = nums[i];
          if (i > 2)
            return min;
        }
      }

      return min;
    }
  }
}