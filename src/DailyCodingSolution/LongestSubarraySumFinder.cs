using System.Collections.Generic;

namespace DailyCodingSolution
{
  /// <summary>
  /// Find the length of the longest contiguous subarray whose sum is less than or equal to k.
  /// </summary>
  public class LongestSubarraySumFinder
  {
    public static int[] GetLongestSubarrayForPositiveNumbers(int[] numbers, int maxSum)
    {
      int leftPointer = 0;
      int rightPointer = 0;
      int currentSum = 0;
      int maxLength = 0;
      int startIndex = 0;

      while (rightPointer < numbers.Length)
      {
        currentSum += numbers[rightPointer];

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
  }
}