using System.Collections.Generic;

namespace DailyCodingSolution
{
  /// <summary>
  /// Valid Parentheses / Balanced Brackets: use a Stack<char> 
  /// to check if a string of brackets is valid. Good test of basic data structure use.
  /// </summary>
  public class BracketsValidator
  {
    public static bool IsValid(string brackets)
    {
      var stack = new Stack<char>();
      foreach (char bracket in brackets)
      {
        switch (bracket)
        {
          case '(':
          case '[':
          case '{':
            stack.Push(bracket);
            break;
          case ')':
            if (stack.Count == 0 || stack.Pop() != '(')
              return false;
            break;
          case ']':
            if (stack.Count == 0 || stack.Pop() != '[')
              return false;
            break;
          case '}':
            if (stack.Count == 0 || stack.Pop() != '{')
              return false;
            break;
        }
      }
      return stack.Count == 0;
    }
  }
}