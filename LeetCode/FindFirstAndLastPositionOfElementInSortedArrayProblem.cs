namespace LeetCode
{
  public class FindFirstAndLastPositionOfElementInSortedArrayProblem
  {
    private int[] Search(int[] nums, int start, int end, int target)
    {
      if (start >= end)
        return nums[start] == target ? new[] {start, start} : new[] {-1, -1};

      int middle = (start + end) / 2;

      if (nums[middle] == target)
      {
        int i = middle;
        while (i >= 0 && nums[i] == target)
          i--;

        int j = middle;
        while (j <= nums.Length - 1 && nums[j] == target)
          j++;

        return new[] {i + 1, j - 1};
      }

      return nums[middle] > target ? Search(nums, start, middle, target) : Search(nums, middle, end, target);
    }

    public int[] SearchRange(int[] nums, int target)
    {
      if (nums.Length == 0)
        return new int[] { -1, -1 };

      return Search(nums, 0, nums.Length - 1, target);
    }
  }
}