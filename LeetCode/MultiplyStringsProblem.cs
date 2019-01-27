using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace LeetCode
{
  public class MultiplyStringsProblem
  {
    public string Multiply(string num1, string num2)
    {
      var list = new List<string>();
      
      var length = Math.Max(num1.Length, num2.Length);
      for (int i = 0; i < length; i++)
      {
        var number = new StringBuilder();

        int carry = 0;
        for (int j = 0; j < length; j++)
        {
          int i2 = num2.Length - 1 - i;
          var n2 = i2 < 0 ? 0 : (int)char.GetNumericValue(num2[i2]);

          int i1 = num1.Length - 1 - j;
          var n1 = i1 < 0 ? 0 : (int)char.GetNumericValue(num1[i1]);

          int res = n1 * n2 + carry;
          if (res >= 10)
          {
            carry = res / 10;
            res = res % 10;
          }
          else
          {
            carry = 0;
          }

          number.Insert(0, res);
        }
        if (carry > 0)
          number.Insert(0, carry);

        for (int zero = 0; zero < i; zero++)
          number.Append('0');

        list.Add(number.ToString());
      }

      var result = new StringBuilder();
      int carry1 = 0;
      for (int shift = 0; shift < list[list.Count - 1].Length; shift++)
      {
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
          var number = list[i];
          int num = number.Length - 1 - shift < 0 ? 0 : (int)char.GetNumericValue(number[number.Length - 1 - shift]);
          sum += num;
        }

        sum += carry1;
        if (sum >= 10)
        {
          carry1 = sum / 10;
          sum = sum % 10;
        }
        else
        {
          carry1 = 0;
        }

        result.Insert(0, sum);
      }

      if (carry1 > 0)
        result.Insert(0, carry1);

      int index = 0;
      while (index < result.Length)
      {
        if (result[index] != '0')
          break;

        index++;
      }

      result.Remove(0, index);
      return result.Length == 0 ? "0" : result.ToString();
    }
  }
}