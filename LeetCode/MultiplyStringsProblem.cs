namespace LeetCode
{
  public class MultiplyStringsProblem
  {
    public string Multiply(string num1, string num2)
    {
      long first = 0;
      for (int i = 0; i < num1.Length; i++)
      {
        first *= 10;
        first += GetInteger(num1[i]);
      }

      long second = 0;
      for (int i = 0; i < num2.Length; i++)
      {
        second *= 10;
        second += GetInteger(num2[i]);
      }

      return (first * second).ToString();
    }

    private long GetInteger(char c)
    {
      switch (c)
      {
        case '0':
          return 0;

        case '1':
          return 1;

        case '2':
          return 2;

        case '3':
          return 3;

        case '4':
          return 4;

        case '5':
          return 5;

        case '6':
          return 6;

        case '7':
          return 7;

        case '8':
          return 8;

        case '9':
          return 9;
      }

      return 0;
    }
  }
}