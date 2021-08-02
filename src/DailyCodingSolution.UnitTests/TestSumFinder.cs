using System;
using System.Collections.Generic;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
  public class TestSumFinder
  {
    [Theory]
    [MemberData(nameof(IsSumPresentTestData))]
    public void TestIsSumPresent(int[] numbers, int sumToFind, bool expectedResult) =>
      Assert.Equal(new SumFinder().IsSumPresent(numbers, sumToFind), expectedResult);

    [Theory]
    [MemberData(nameof(IsSumPresentTestData))]
    public void TestIsSumPresentOnePass(int[] numbers, int sumToFind, bool expectedResult) =>
      Assert.Equal(new SumFinder().IsSumPresentOnePass(numbers, sumToFind), expectedResult);

    public static IEnumerable<object[]> IsSumPresentTestData =>
      new List<object[]>
      {
        new object[] { new[] { 10, 15, 3, 7 }, 17, true },
        new object[] {new[] { 10, 15, 3, 7 }, 29, false }
      };
  }
}
