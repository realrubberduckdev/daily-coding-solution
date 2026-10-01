using System;
using System.Collections.Generic;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
  public class TestLongestSubarraySumFinder
  {
    [Fact]
    public void ThrowsWhenNumbersIsEmpty()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
          LongestSubarraySumFinder.GetLongestSubarrayForPositiveNumbers([], 10));
    }

    [Fact]
    public void ThrowsWhenNumbersContainsNonPositiveValue()
    {
      Assert.Throws<ArgumentException>(() =>
          LongestSubarraySumFinder.GetLongestSubarrayForPositiveNumbers([2, 0, 4], 10));
    }

    [Fact]
    public void ThrowsWhenNumbersContainsNegativeValue()
    {
      Assert.Throws<ArgumentException>(() =>
          LongestSubarraySumFinder.GetLongestSubarrayForPositiveNumbers([2, -1, 4], 10));
    }

    [Theory]
    [MemberData(nameof(GetLongestSubarrayForPositiveNumbersTestData))]
    public void TestGetLongestSubarrayForPositiveNumbers(
      int[] numbers,
      int targetSum,
      int[] expectedResult)
    {
      var actual = LongestSubarraySumFinder
          .GetLongestSubarrayForPositiveNumbers(numbers, targetSum);

      Assert.Equal(expectedResult, actual);
    }

    public static IEnumerable<ITheoryDataRow> GetLongestSubarrayForPositiveNumbersTestData =>
    [
      new TheoryDataRow<int[], int, int[]>([10, 15, 3, 7], 17, [3, 7])
          .WithTestDisplayName("Returns longest subarray totaling <=17"),

      new TheoryDataRow<int[], int, int[]>([2, 4, 6, 8, 10, 12, 16], 14, [2, 4, 6])
      .WithTestDisplayName("Returns longest subarray totaling <=14"),

      new TheoryDataRow<int[], int, int[]>([10, 15, 3, 7], 2, [])
      .WithTestDisplayName("Returns empty array when no match exists")
    ];

    [Theory]
    [MemberData(nameof(GetLongestSubarrayTestData))]
    public void TestGetLongestSubarray(
      int[] numbers,
      int targetSum,
      int[] expectedResult)
    {
      var actual = LongestSubarraySumFinder
          .GetLongestSubarray(numbers, targetSum);

      Assert.Equal(expectedResult, actual);
    }

    public static IEnumerable<ITheoryDataRow> GetLongestSubarrayTestData =>
    [
      new TheoryDataRow<int[], int, int[]>([10, -15, 3, 7], 17, [10, -15, 3, 7])
          .WithTestDisplayName("Returns longest subarray totaling <=17"),

      new TheoryDataRow<int[], int, int[]>([2, 4, 6, 8, -10, 12, 16], 14, [2, 4, 6])
      .WithTestDisplayName("Returns longest subarray totaling <=14"),

      new TheoryDataRow<int[], int, int[]>([10, 15, 3, 7], 2, [])
      .WithTestDisplayName("Returns empty array when no match exists")
    ];
  }
}