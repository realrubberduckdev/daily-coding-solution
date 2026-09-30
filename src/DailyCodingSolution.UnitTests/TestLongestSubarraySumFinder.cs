using System.Collections.Generic;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
    public class TestLongestSubarraySumFinder
    {
        [Theory]
        [MemberData(nameof(FindPairsTestData))]
        public void TestGetLongestSubarrayForPositiveNumbers(
          int[] numbers,
          int targetSum,
          int[] expectedResult)
        {
            var actual = LongestSubarraySumFinder
                .GetLongestSubarrayForPositiveNumbers(numbers, targetSum);

            Assert.Equal(expectedResult, actual);
        }

        public static IEnumerable<ITheoryDataRow> FindPairsTestData =>
        [
          new TheoryDataRow<int[], int, int[]>([10, 15, 3, 7], 17, [3, 7])
          .WithTestDisplayName("Returns longest subarray totaling <=17"),
          
          new TheoryDataRow<int[], int, int[]>([2, 4, 6, 8, 10, 12, 16], 14, [2, 4, 6])
          .WithTestDisplayName("Returns longest subarray totaling <=14"),
          
          new TheoryDataRow<int[], int, int[]>([10, 15, 3, 7], 2, [])
          .WithTestDisplayName("Returns empty array when no match exists")
        ];
    }
}