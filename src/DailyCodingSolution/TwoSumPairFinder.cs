using System.Collections.Generic;

namespace DailyCodingSolution
{
    /// <summary>
    /// Two Sum (with a twist): given an array, find all pairs that sum to a target. 
    /// Practice using a HashSet<int> or Dictionary<int, int> for O(n) solution.
    /// </summary>
    public class TwoSumPairFinder
    {
        public List<(int, int)> FindPairs(int[] numbers, int targetSum)
        {
            var pairs = new List<(int, int)>();
            var seenNumbers = new HashSet<int>();
            foreach (var number in numbers)
            {
                var complement = targetSum - number;
                if (seenNumbers.Contains(complement))
                {
                    pairs.Add((number, complement));
                }
                seenNumbers.Add(number);
            }
            return pairs;
        }
    }
}