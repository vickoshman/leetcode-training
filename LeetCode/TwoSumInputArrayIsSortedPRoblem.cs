using System.Globalization;

namespace LeetCode
{
  public class TwoSumInputArrayIsSortedProblem
  {
    public int[] TwoSum(int[] numbers, int target)
    {
      for (int i = 0; i < numbers.Length - 1; i++)
      {
        for (int j = numbers.Length - 1; j > i; j--)
        {
          if (numbers[i] + numbers[j] == target)
            return new int[] {i + 1, j + 1};
        }
      }

      return null;
    }
  }
}