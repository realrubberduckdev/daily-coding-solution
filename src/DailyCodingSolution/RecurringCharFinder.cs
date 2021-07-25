namespace DailyCodingSolution
{
    /// <summary>
    /// Problem #159 [Easy]
    /// This problem was asked by Google.
    /// Given a string, return the first recurring character in it, or null if there is no recurring character.
    /// For example, given the string "acbbac", return "b". Given the string "abcdef", return null.
    /// </summary>
    public static class RecurringCharFinder
    {
        public static string GetRecurringChar(string stringValue)
        {
            for (int i = 0; i < stringValue.Length - 1; i++)
            {
                if (stringValue[i] == stringValue[i + 1])
                {
                    return stringValue[i].ToString();
                }
            }

            return null;
        }
    }
}