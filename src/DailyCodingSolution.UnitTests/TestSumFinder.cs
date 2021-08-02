using System;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
  public class TestSumFinder
  {
    [Theory]
    [InlineData(new[] { 10, 15, 3, 7 }, 17, true)]
    public void TestIsSumPresent(int[] numbers, int sumToFind, bool expectedResult) =>
      Assert.Equal(SumFinder.IsSumPresent(numbers, sumToFind), expectedResult);
  }
}
