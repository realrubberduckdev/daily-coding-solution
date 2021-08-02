﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingSolution
{
  /// <summary>
  /// Problem #1 [Easy]
  /// This problem was recently asked by Google.
  /// Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
  /// For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
  /// Bonus: Can you do this in one pass?
  /// </summary>
  public static class SumFinder
  {
    public static bool IsSumPresent(int[] numbers, int sumToFind)
    {
      for (var i = 0; i < numbers.Length -1; i++)
      {
        for (var j = i + 1; j < numbers.Length; j++)
        {
          if ((numbers[i] + numbers[j]) == sumToFind)
            return true;
        }
      }

      return false;
    }
  }
}