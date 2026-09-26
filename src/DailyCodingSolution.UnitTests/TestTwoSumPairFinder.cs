using System.Collections.Generic;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
    public class TestTwoSumPairFinder
    {
        [Theory]
        [MemberData(nameof(FindPairsTestData))]
        public void TestFindPairs(int[] numbers, int targetSum, List<(int, int)> expectedResult) =>
          Assert.Equal(expectedResult, new TwoSumPairFinder().FindPairs(numbers, targetSum));


        public static IEnumerable<object[]> FindPairsTestData =>
          new List<object[]>
          {
            new object[] { new[] { 10, 15, 3, 7 }, 17, new List<(int, int)> { (7, 10) } },
            new object[] { new[] { 2, 4, 6, 8, 10, 12, 16 }, 14, new List<(int, int)> { (8, 6), (10, 4), (12, 2) } },
            new object[] {new[] { 10, 15, 3, 7 }, 29, new List<(int, int)>() }
          };
    }
}