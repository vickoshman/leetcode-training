namespace LeetCode
{
  public class ProductOfArrayExceptSelfProblem
  {
    public int[] ProductExceptSelf(int[] nums)
    {
      var res = new int[nums.Length];

      res[0] = 1;
      for (int i = 1; i < nums.Length; i++)
      {
        res[i] = res[i - 1] * nums[i - 1];
      }

      int right = 1;
      for (int i = nums.Length - 1; i >= 0; i--)
      {
        res[i] *= right;
        right *= nums[i];
      }

      return res;
    }
  }
}