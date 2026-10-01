using System;
using System.Collections.Generic;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
  public class TestArraySearch
  {
    [Theory]
    [MemberData(nameof(LinearSearchTestData))]
    public void TestLinearSearch(
      int[] numbers,
      int element,
      bool expectedResult)
    {
      var actual = ArraySearch.LinearSearch(numbers, element);
      Assert.Equal(expectedResult, actual);
    }

    [Theory]
    [MemberData(nameof(BinarySearchTestData))]
    public void TestBinarySearch(
      int[] numbers,
      int element,
      bool expectedResult)
    {
      var actual = ArraySearch.BinarySearch(numbers, element);
      Assert.Equal(expectedResult, actual);
    }

    public static IEnumerable<ITheoryDataRow> BinarySearchTestData =>
    [
      new TheoryDataRow<int[], int, bool>([3, 7, 10, 15, 17], 17, true)
      .WithTestDisplayName("Element 17 is found"),

      new TheoryDataRow<int[], int, bool>([2, 4, 6, 8, 10, 12, 16], 14, false)
      .WithTestDisplayName("Element 14 is not found"),

      new TheoryDataRow<int[], int, bool>([3, 7, 10, 15], 2, false)
      .WithTestDisplayName("Element 2 is not found")
    ];

    public static IEnumerable<ITheoryDataRow> LinearSearchTestData =>
    [
      new TheoryDataRow<int[], int, bool>([10, 15, 3, 17], 17, true)
      .WithTestDisplayName("Element 17 is found"),

      new TheoryDataRow<int[], int, bool>([2, 4, 6, 8, 10, 12, 16], 14, false)
      .WithTestDisplayName("Element 14 is not found"),

      new TheoryDataRow<int[], int, bool>([10, 15, 3, 7], 2, false)
      .WithTestDisplayName("Element 2 is not found")
    ];
  }
}