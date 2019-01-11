using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace LeetCode
{
  public class ZigZagConversionProblem
  {
    public string Convert(string s, int numRows)
    {
      var zig = new List<char[]>();
      bool isDiag = false;

      for (int i = 0; i < s.Length;)
      {
        if (!isDiag)
        {
          var column = new char[numRows];
          for (int j = 0; j < numRows && i < s.Length; j++)
            column[j] = s[i++];
          zig.Add(column);
        }
        else
        {
          for (int j = numRows - 2; j > 0 && i < s.Length; j--)
          {
            var column = new char[numRows];
            column[j] = s[i++];
            zig.Add(column);
          }
        }

        isDiag = !isDiag;
      }

      char[] result = new char[s.Length];
      int index = 0;
      for (int j = 0; j < numRows; j++)
      {
        for (int i = 0; i < zig.Count; i++)
        {
          var row = zig[i];
          if (row.Length > j && index < s.Length && row[j] != '\0')
            result[index++] = row[j];
        }
      }

      return new string(result);
    }
  }
}