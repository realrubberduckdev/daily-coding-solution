using System.Collections.Generic;

namespace DailyCodingSolution
{
  /// <summary>
  /// Problem #1 [Easy]
  /// This problem was recently asked by Google.
  /// Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
  /// For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
  /// Bonus: Can you do this in one pass?
  /// </summary>
  public class SumFinder
  {
    /// <summary>
    /// Check if sum present without one pass.
    /// </summary>
    /// <param name="numbers">Array of numbers to search within.</param>
    /// <param name="sumToFind">Sum value to locate.</param>
    /// <returns>True if value can be calculated using two numbers in array.</returns>
    public bool IsSumPresent(int[] numbers, int sumToFind)
    {
      for (var i = 0; i < numbers.Length - 1; i++)
      {
        for (var j = i + 1; j < numbers.Length; j++)
        {
          if ((numbers[i] + numbers[j]) == sumToFind)
            return true;
        }
      }

      return false;
    }

    /// <summary>
    /// Check if sum present with one pass. Bonus.
    /// </summary>
    /// <param name="numbers">Array of numbers to search within.</param>
    /// <param name="sumToFind">Sum value to locate.</param>
    /// <returns>True if value can be calculated using two numbers in array.</returns>
    public bool IsSumPresentOnePass(int[] numbers, int sumToFind)
    {
      var differences = new List<int>();
      var sumFound = false;
      foreach (var number in numbers)
      {
        var diff = sumToFind - number;
        if (differences.Contains(diff))
        {
          sumFound = true;
          break;
        }

        differences.Add(number);
      }

      return sumFound;
    }
  }
}