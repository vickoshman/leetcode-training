namespace LeetCode
{
  public class RotateArrayProblem
  {
    public void Rotate(int[] nums, int k)
    {
      if (nums.Length == 1)
        return;

      if (k > nums.Length)
        k = k % nums.Length;

      for (int i = 0; i < k; i++)
      {
        int last = nums[nums.Length - 1];
        for (int j = nums.Length - 1; j >= 1; j--)
        {
          nums[j] = nums[j - 1];
        }

        nums[0] = last;
      }
    }
  }
}