using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace LeetCode
{
  public class StringToIntegerProblem
  {
    public int MyAtoi(string str)
    {
      if (string.IsNullOrWhiteSpace(str))
        return 0;

      int startIndex = 0;
      bool negative = false;
      for (int i = 0; i < str.Length; i++)
      {
        var c = str[i];
        startIndex = i;

        if (c == '-')
        {
          negative = true;
          startIndex++;
          break;
        }

        if (c == '+')
        {
          startIndex++;
          break;
        }

        if (c == ' ')
          continue;

        if (GetNumber(c) > -1)
          break;

        return 0;
      }

      int result = 0;
      for (int i = startIndex; i < str.Length; i++)
      {
        var c = str[i];
        var number = GetNumber(c);
        if (number < 0)
          break;

        int initial = result;
        result *= 10;
        result += number;

        if (result/10 != initial)
          return negative ? int.MinValue : int.MaxValue;
      }

      return negative ? -result : result;
    }

    public int GetNumber(char c)
    {
      if (c == '0')
        return 0;

      if (c == '1')
        return 1;

      if (c == '2')
        return 2;

      if (c == '3')
        return 3;

      if (c == '4')
        return 4;

      if (c == '5')
        return 5;

      if (c == '6')
        return 6;

      if (c == '7')
        return 7;

      if (c == '8')
        return 8;

      if (c == '9')
        return 9;

      return -1;
    }
  }
}