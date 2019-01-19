namespace LeetCode
{
  public class RemoveDuplicatesFromSortedArrayIIProblem
  {
    public int RemoveDuplicates(int[] nums)
    {
      if (nums.Length < 2)
        return nums.Length;

      int prev = nums[0];
      bool skipped = false;
      int length = nums.Length;

      for (int i = 1; i < length; i++)
      {
        if (nums[i] != prev)
        {
          prev = nums[i];
          skipped = false;
          continue;
        }

        if (nums[i] == prev && !skipped)
        {
          skipped = true;
          continue;
        }

        if (nums[i] == prev && skipped)
        {
          for (int j = i; j < length - 1; j++)
          {
            nums[j] = nums[j + 1];
          }

          i--;
          length--;
        }
      }

      return length;
    }
  }
}