namespace LeetCode
{
  public class MissingNumberProblem
  {
    public int MissingNumber(int[] nums)
    {
      int s = 0;
      int sum = 0;

      for (int i = 0; i < nums.Length; i++)
      {
        sum += nums[i];
        s += i;
      }

      return s+nums.Length - sum;
    }
  }
}