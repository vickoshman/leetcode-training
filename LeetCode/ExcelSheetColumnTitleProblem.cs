using System.Collections.Generic;

namespace LeetCode
{
  public class ExcelSheetColumnTitleProblem
  {
    public string ConvertToTitle(int n)
    {
      int baseCode = 65;
      int sum = 0;

      var codes = new List<int>();
      int res = n / 26;
      int rem = 0;
      while (res > 1)
      {
        if (res <= 26)
        {
          codes.Add(res);
        }
        else
        {
          codes.Add(res-26);
          res = 26;
        }

        res = n - res*26;
        
      }

      return "";
    }
  }
}