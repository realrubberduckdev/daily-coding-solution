using System.Collections.Generic;
using System.Linq;

namespace DailyCodingSolution
{
  /// <summary>
  /// Problem #176 [Easy]
  /// This problem was asked by Bloomberg.
  /// Determine whether there exists a one-to-one character mapping from one string s1 to another s2.
  /// For example, given s1 = abc and s2 = bcd, return true since we can map a to b, b to c, and c to d.
  /// Given s1 = foo and s2 = bar, return false since the o cannot map to two characters.
  /// </summary>
  public static class CharMapper
  {
    public static bool IsOneToOneMappingPresent(string firstString, string secondString)
    {
      if (string.IsNullOrEmpty(firstString) || string.IsNullOrEmpty(secondString))
      {
        return false;
      }

      if (firstString.Length != secondString.Length)
      {
        return false;
      }

      return HasUniqueChars(firstString) && HasUniqueChars(secondString);
    }

    /// <summary>
    /// Check that all characters in provided string are unique.
    /// </summary>
    /// <param name="itemToCheck">String item to check for duplicate items.</param>
    /// <returns>True if all unique else false.</returns>
    public static bool HasUniqueChars(string itemToCheck) => itemToCheck.Distinct().Count().Equals(itemToCheck.Length);
  }
}