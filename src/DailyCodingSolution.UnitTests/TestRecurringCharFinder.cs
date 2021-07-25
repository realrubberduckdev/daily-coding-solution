using NUnit.Framework;

namespace DailyCodingSolution.UnitTests
{
    public class TestRecurringCharFinder
    {
        [TestCase("abcde", ExpectedResult = null)]
        [TestCase("abbcde", ExpectedResult = "b")]
        [TestCase("abcdee", ExpectedResult = "e")]
        [TestCase("abbcdee", ExpectedResult = "b")]
        public string TestGetRecurringChar(string input) => RecurringCharFinder.GetRecurringChar(input);
    }
}