using System;
using System.Collections.Generic;

namespace DailyCodingSolution
{
  /// <summary>
  /// Find the length of the longest contiguous subarray whose sum is less than or equal to k.
  /// </summary>
  public class LongestSubarraySumFinder
  {
    /// <summary>
    /// Get the longest contiguous subarray whose sum is less than or equal to the specified maximum sum.
    /// </summary>
    /// <param name="numbers">The array of positive numbers to search within.</param>
    /// <param name="maxSum">The maximum allowed sum for the subarray.</param>
    /// <returns>The longest contiguous subarray whose sum is less than or equal to <paramref name="maxSum"/>.</returns>
    /// <exception cref="ArgumentException">Thrown when any element in <paramref name="numbers"/> is not positive.</exception>
    public static int[] GetLongestSubarrayForPositiveNumbers(int[] numbers, int maxSum)
    {
      ArgumentOutOfRangeException.ThrowIfZero(numbers.Length, nameof(numbers));

      int leftPointer = 0;
      int rightPointer = 0;
      int currentSum = 0;
      int maxLength = 0;
      int startIndex = 0;

      while (rightPointer < numbers.Length)
      {
        int number = numbers[rightPointer];
        if (number <= 0)
        {
            throw new ArgumentException(
                $"Element at index {rightPointer} must be positive.",
                nameof(numbers));
        }
        currentSum += number;

        while (currentSum > maxSum && leftPointer <= rightPointer)
        {
          currentSum -= numbers[leftPointer];
          leftPointer++;
        }

        int currentLength = rightPointer - leftPointer + 1;
        if (currentLength > maxLength)
        {
          maxLength = currentLength;
          startIndex = leftPointer;
        }

        rightPointer++;
      }

      int[] result = new int[maxLength];
      for (int i = 0; i < maxLength; i++)
      {
        result[i] = numbers[startIndex + i];
      }

      return result;
    }

    /// <summary>
    /// Get the longest contiguous subarray whose sum is less than or equal to the specified maximum sum.
    /// </summary>
    /// <param name="numbers">The array of numbers to search within, can have negative numbers.</param>
    /// <param name="maxSum">The maximum allowed sum for the subarray.</param>
    /// <returns>The longest contiguous subarray whose sum is less than or equal to <paramref name="maxSum"/>.</returns>
    public static int[] GetLongestSubarray(int[] numbers, int maxSum)
    {
      int prefixSum = 0;
      int maxLength = 0;
      int startIndex = 0;
      int leftPointer = 0;

      for (int rightPointer = 0; rightPointer < numbers.Length; rightPointer++)
      {
        prefixSum += numbers[rightPointer];

        while (prefixSum > maxSum && leftPointer <= rightPointer)
        {
          prefixSum -= numbers[leftPointer];
          leftPointer++;
        }

        int currentLength = rightPointer - leftPointer + 1;
        if (currentLength > maxLength)
        {
          maxLength = currentLength;
          startIndex = leftPointer;
        }
      }

      int[] result = new int[maxLength];
      for (int i = 0; i < maxLength; i++)
      {
        result[i] = numbers[startIndex + i];
      }

      return result;
    }
  }
}