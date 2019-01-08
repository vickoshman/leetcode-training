using System.IO.Ports;

namespace LeetCode
{
  public class WordSearchProblem
  {
    private bool Search(char[,] board, string word, int index, int i, int j)
    {
      if (index == word.Length)
        return true;

      if (i  < 0 || j < 0 || i >= board.GetLength(0) || j >= board.GetLength(1) || word[index] != board[i, j])
        return false;

      char c = board[i,j];
      board[i,j] = '*';

      var res = Search(board, word, index + 1, i + 1, j) ||
                Search(board, word, index + 1, i, j + 1) ||
                Search(board, word, index + 1, i - 1, j) ||
                Search(board, word, index + 1, i, j - 1);

      board[i,j] = c;
      return res;
    }

    public bool Exist(char[,] board, string word)
    {
      for (int i = 0; i < board.GetLength(0); i++)
      {
        for (int j = 0; j < board.GetLength(1); j++)
        {
          if (board[i, j] == word[0] && Search(board, word, 0, i, j))
            return true;
        }
      }

      return false;
    }
  }
}