using System;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
  public class TestRecurringCharFinder
  {
    [Theory]
    [InlineData("abcde", null)]
    [InlineData("abbcde", "b")]
    [InlineData("abcdee", "e")]
    [InlineData("abbcdee", "b")]
    public void TestGetRecurringChar(string input, string expectedResult) => Assert.Equal(RecurringCharFinder.GetRecurringChar(input), expectedResult);
  }
}
