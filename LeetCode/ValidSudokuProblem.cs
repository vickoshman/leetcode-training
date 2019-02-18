using System.Collections.Generic;

namespace LeetCode
{
  public class ValidSudokuProblem
  {
    public bool IsValidSudoku(char[,] board)
    {
      int n = board.GetLength(0);
      int m = board.GetLength(1);

      if (n != 9 || m != 9)
        return false;

      bool valid;
      for (int i = 0; i < board.GetLength(0); i++)
      {
        var setH = new HashSet<int>();
        var setV = new HashSet<int>();

        int sumH = 0;
        int sumV = 0;

        for (int j = 0; j < board.GetLength(1); j++)
        {
          if (j % 3 == 0 && i % 3 == 0)
          {
            int sum = 0;
            var set = new HashSet<int>();

            for (int k = 0; k < 3; k++)
            {
              for (int l = 0; l < 3; l++)
              {
                sum = Process(board[i + k, j + l], set, sum, out valid);
                if (!valid)
                  return false;
              }
            }
          }

          sumH = Process(board[i, j], setH, sumH, out valid);
          if (!valid)
            return false;

          sumV = Process(board[j, i], setV, sumV, out valid);
          if (!valid)
            return false;
        }
      }

      return true;
    }

    private int Process(char symb, HashSet<int> set, int sum, out bool valid)
    {
      valid = true;
      if (!char.IsDigit(symb))
        return 0;

      valid = false;
      var value = (int)char.GetNumericValue(symb);
      if (value < 1)
        return 0;

      sum += value;
      if (sum <= 45 && set.Add(value))
        valid = true;

      return sum;
    }
  }
}