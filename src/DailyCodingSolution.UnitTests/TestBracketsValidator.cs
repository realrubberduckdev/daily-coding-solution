using System.Collections.Generic;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
  public class TestBracketsValidator
  {
    [Theory]
    [MemberData(nameof(IsValidTestData))]
    public void TestIsValid(string brackets, bool expectedResult) =>
      Assert.Equal(expectedResult, BracketsValidator.IsValid(brackets));

    public static IEnumerable<object[]> IsValidTestData =>
      new List<object[]>
      {
            new object[] { "()", true },
            new object[] { "[]", true },
            new object[] { "{}", true },
            new object[] { "([{}])", true },
            new object[] { "([)]", false },
            new object[] { "{(}[)]", false }
      };
  }
}