namespace LeetCode
{
  public class ContainsDuplicateIIProblem
  {
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
      for (int i = 0; i < nums.Length - 1; i++)
      {
        for (int j = i + 1; j < i + k + 1 && j < nums.Length; j++)
        {
          if (nums[i] == nums[j])
            return true;
        }
      }

      return false;
    }
  }
}