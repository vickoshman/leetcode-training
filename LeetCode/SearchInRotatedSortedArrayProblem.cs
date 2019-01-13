namespace LeetCode
{
  public class SearchInRotatedSortedArrayProblem
  {
    private int FindPivotIndex(int[] nums, int from, int to)
    {
      if (from != 0 && nums[from] < nums[from - 1])
        return from;

      if (nums[from] > nums[0])
        return FindPivotIndex(nums, (from + to) / 2, to);
      else
        return FindPivotIndex(nums, (from + to) / 2, to);
    }

    public int Search(int[] nums, int target)
    {
      int pivot = FindPivotIndex(nums, 0, nums.Length - 1);
      return pivot;
    }
  }
}