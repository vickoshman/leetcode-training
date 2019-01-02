namespace LeetCode
{
  public class AddOneProblem
  {
    public int[] PlusOne(int[] digits)
    {
      int i = digits.Length - 1;

      while (i >= 0)
      {
        if (digits[i] != 9)
        {
          digits[i]++;
          return digits;
        }
        else
        {
          digits[i] = 0;
          i--;
        }
      }

      var result = new int[digits.Length + 1];
      result[0] = 1;
      return result;
    }
  }
}