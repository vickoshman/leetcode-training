using System.Collections.Generic;

namespace LeetCode
{
  public class WordPatternProblem
  {
    public bool WordPattern(string pattern, string str)
    {
      var words = str.Split(' ');
      if (words.Length != pattern.Length)
        return false;

      Dictionary<string, char> _word = new Dictionary<string, char>();
      Dictionary<char, string> _c = new Dictionary<char, string>();

      for (int i = 0; i < words.Length; i++)
      {
        var c = pattern[i];
        var word = words[i];

        if (!_word.ContainsKey(word))
          _word.Add(word, c);
        else if (_word[word] != c)
          return false;

        if (!_c.ContainsKey(c))
          _c.Add(c, word);
        else if (_c[c] != word)
          return false;
      }

      return true;
    }
  }
}