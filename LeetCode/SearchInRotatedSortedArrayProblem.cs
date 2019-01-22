namespace LeetCode
{
  public class SearchInRotatedSortedArrayProblem
  {
    public int Search(int[] nums, int target)
    {
      if (nums.Length == 0)
        return -1;

      if (nums.Length == 1)
        return nums[0] == target ? 0 : -1;

      if (nums.Length == 2)
        return nums[0] == target ? 0 : nums[1] == target ? 1 : -1;

      int arrayStartIndex = -1;
      if (nums[0] < nums[nums.Length - 1])
        arrayStartIndex = 0;
      else
      {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
          int mid = left + (right - left) / 2;
          if (nums[mid] > nums[mid + 1])
          {
            arrayStartIndex = mid + 1;
            break;
          }

          if (nums[mid - 1] > nums[mid])
          {
            arrayStartIndex = mid;
            break;
          }

          if (nums[0] < nums[mid])
            left = mid + 1;
          else
            right = mid - 1;
        }
      }

      if (nums[arrayStartIndex] == target)
        return arrayStartIndex;

      int l = 0;
      int r = 0;

      if (target > nums[nums.Length - 1])
      {
        l = 0;
        r = arrayStartIndex - 1;
      }
      else
      {
        l = arrayStartIndex;
        r = nums.Length;
      }

      while (l <= r)
      {
        int mid = l + (r - l) / 2;

        if (nums[mid] == target)
          return mid;

        if (nums[mid] > target)
        {
          r = mid - 1;
        }
        else
        {
          l = mid + 1;
        }
      }

      return -1;
    }
  }
}