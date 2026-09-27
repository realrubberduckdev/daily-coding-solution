using System.Collections.Generic;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
  public class TestAnagramFinder
  {
    [Theory]
    [MemberData(nameof(GroupAnagramsTestData))]
    public void TestGroupAnagrams(string[] words, List<List<string>> expectedResult) =>
      Assert.Equal(new AnagramFinder().GroupAnagrams(words), expectedResult);

    public static IEnumerable<object[]> GroupAnagramsTestData =>
      new List<object[]>
      {
        new object[]
        {
          new[] { "eat", "tea", "tan", "ate", "nat", "bat" },
          new List<List<string>>
          {
            new() { "eat", "tea", "ate" },
            new() { "tan", "nat" },
            new() { "bat" }
          }
        },
        new object[]
        {
          new[] { "abc", "bca", "cab" },
          new List<List<string>>
          {
            new() { "abc", "bca", "cab" }
          }
        },
        new object[]
        {
          new[] { "" },
          new List<List<string>>
          {
            new() { "" }
          }
        }
      };
  }
}