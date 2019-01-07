using System.Collections.Generic;
using System.Linq;

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

    public void Backtrack(string digits, int digitIndex, char[] snippet, List<string> result)
    {
      if (digitIndex == digits.Length)
      {
        result.Add(new string(snippet.ToArray()));
        return;
      }

      var digit = digits[digitIndex];
      var letters = dict[digit];
      for (int i = 0; i < letters.Count; i++)
      {
        snippet[digitIndex] = letters[i];
        Backtrack(digits, digitIndex + 1, snippet, result);
      }
    }

    public IList<string> LetterCombinations(string digits)
    {
      var result = new List<string>();

      if (digits == null || digits.Length == 0)
        return result;
      
      Backtrack(digits, 0, new char[digits.Length], result);
      return result;
    }
  }
}