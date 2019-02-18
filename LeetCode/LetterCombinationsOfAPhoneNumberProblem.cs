using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
  public class LetterCombinationsOfAPhoneNumberProblem
  {
    Dictionary<int, List<char>> dict = new Dictionary<int, List<char>>
    {
      {'2', new List<char> {'a', 'b', 'c'}},
      {'3', new List<char> {'d', 'e', 'f'}},
      {'4', new List<char> {'g', 'h', 'i'}},
      {'5', new List<char> {'j', 'k', 'l'}},
      {'6', new List<char> {'m', 'n', 'o'}},
      {'7', new List<char> {'p', 'q', 'r', 's'}},
      {'8', new List<char> {'t', 'u', 'v'}},
      {'9', new List<char> {'w', 'x', 'y', 'z'}}
    };

    private void Build(string digits, StringBuilder soFar, int from, List<string> result)
    {
      if (soFar.Length == digits.Length)
      {
        result.Add(soFar.ToString());
        return;
      }

      foreach (var c in dict[digits[from]])
      {
        soFar.Append(c);
        Build(digits, soFar, from + 1, result);
        soFar.Remove(soFar.Length - 1, 1);
      }
    }

    public IList<string> LetterCombinations(string digits)
    {
      if (digits == null || digits.Length == 0)
        return new List<string>();

      var result = new List<string>();
      Build(digits, new StringBuilder(), 0, result);
      return result;
    }
  }
}