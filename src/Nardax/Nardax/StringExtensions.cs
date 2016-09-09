using System;
using System.ComponentModel;

namespace Nardax
{
  // Klipp av en sträng från vänster
  public static class StringExtensions
  {
    public static string TruncateLeft(this string value, int maxLength)
    {
      var startIndex = value.Length - maxLength;

      if (startIndex < 1)
      {
        return value;
      }

      return value.Substring(startIndex, maxLength);
    }
  }
}
