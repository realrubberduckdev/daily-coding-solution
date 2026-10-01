using System.Collections.Generic;
using System.Linq;

namespace DailyCodingSolution
{
  /// <summary>
  /// Search for an element in an array.
  /// </summary>
  public class ArraySearch
  {
    /// <summary>
    /// Search for an element in an array using linear search.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <param name="element">The element to search for.</param>
    /// <returns>True if the element is found, otherwise false.</returns>
    public static bool LinearSearch(int[] array, int element)
    {
      foreach (var item in array)
      {
        if (item == element)
        {
          return true;
        }
      }
      return false;
    }

    /// <summary>
    /// Search for an element in a sorted array using binary search.
    /// </summary>
    /// <param name="array">The sorted array to search.</param>
    /// <param name="element">The element to search for.</param>
    /// <returns>True if the element is found, otherwise false.</returns>
    public static bool BinarySearch(int[] array, int element)
    {
      int left = 0;
      int right = array.Length - 1;
      while (left <= right)
      {
        int mid = left + (right - left) / 2;
        if (array[mid] == element)
        {
          return true;
        }
        if (array[mid] < element)
        {
          left = mid + 1;
        }
        else
        {
          right = mid - 1;
        }
      }
      return false;
    }
  }
}