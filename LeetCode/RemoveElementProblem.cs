namespace LeetCode
{
  public class RemoveElementProblem
  {
    public int RemoveElement(int[] nums, int val)
    {
      int length = nums.Length;
      for (int i = 0; i < length; i++)
      {
        int value1 = nums[i];
        if (value1 != val)
          continue;

        for (int j = i + 1; j < length; j++)
        {
          int temp = nums[j];
          nums[j] = nums[j - 1];
          nums[j - 1] = temp;
        }

        length--;
      }

      return length;
    }
  }
}