using System.Collections.Generic;
using System.Linq;

namespace DailyCodingSolution
{
  /// <summary>
  /// Group Anagrams: given a list of strings, group them by anagram.
  /// Practice Dictionary<string, List<string>> and LINQ for sorting/grouping.
  /// </summary>
  public class AnagramFinder
  {
    /// <summary>
    /// Group anagrams together.
    /// </summary>
    /// <param name="words">List of words to group.</param>
    /// <returns>List of grouped anagrams.</returns>
    public List<List<string>> GroupAnagrams(string[] words)
    {
      var anagramGroups = new Dictionary<string, List<string>>();

      foreach (var word in words)
      {
        // Sort the characters in the word to create a key
        var sortedWord = new string(word.ToCharArray().OrderBy(c => c).ToArray());

        if (!anagramGroups.TryGetValue(sortedWord, out List<string> value))
        {
          value = new List<string>();
          anagramGroups[sortedWord] = value;
        }

        value.Add(word);
      }

      return anagramGroups.Values.ToList();
    }
  }
}