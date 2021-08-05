using System.Collections.Generic;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
  public class TestCharMapper
  {
    [Theory]
    [InlineData("abc", "bcd", true)]
    [InlineData("foo", "bar", false)]
    public void TestIsOneToOneMappingPresent(string firstString, string secondString, bool expectedResult) =>
      Assert.Equal(CharMapper.IsOneToOneMappingPresent(firstString, secondString), expectedResult);

    [Theory]
    [InlineData("abc",true)]
    [InlineData("foo",false)]
    public void TestHasUniqueChars(string itemToCheck, bool expectedResult) =>
      Assert.Equal(CharMapper.HasUniqueChars(itemToCheck), expectedResult);
  }
}