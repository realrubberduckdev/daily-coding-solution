using System.Collections.Generic;

namespace DailyCodingSolution
{
    /// <summary>
    /// Two Sum (with a twist): given an array, find all pairs that sum to a target. 
    /// Practice using a HashSet<int> or Dictionary<int, int> for O(n) solution.
    /// </summary>
    public class TwoSumPairFinder
    {
        /// <summary>
        /// Why HashSet<int> is a good choice
        // O(1) average-case lookup: seenNumbers.Contains(complement) checks membership in constant time, 
        // regardless of how many numbers have been seen. This keeps the whole function at O(n) time.
        // Contrast with List<int>: A linear scan per lookup would make the total complexity O(n²) 
        // in the worst case.
        // Semantic fit: A set naturally expresses “has this value been seen?” 
        // and inherently handles the “no duplicates” intent of the tracking variable.
        // Complexity
        // Time: 
        // O(n) one pass through the array, each Contains is constant time.
        // Space: 
        // O(n) the hash set stores at most one entry per input number.
        /// </summary>
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