using System;
using System.ComponentModel;

namespace Nardax
{
  using System.Text;
  using System.Text.RegularExpressions;

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

    // Klipp av en sträng från höger

    public static string TruncateRight(this string value, int maxLength)
    {
      if (value.Length < maxLength)
      {
        return value;
      }

      return value.Substring(0, maxLength);
    }

    public static string RemoveWhiteChars(this string value)
    {
      return Regex.Replace(value, "\\s", "");
    }

    public static string RepeatMe(this string value, int times = 5)
    {
      var sb = new StringBuilder();

      for (var i = 0; i < times; i++)
      {
        sb.Append(value);
      }
      return sb.ToString();
    }

    public static string AddCharBetween(this string value, char c)
    {
      if (value == null)
        return null;

      var sb = new StringBuilder();

      foreach (var x in value)
      {
        sb.Append(x);
        sb.Append(c);
      }

      if (sb.Length > 1)
        sb.Remove(sb.Length - 1, 1);

      return sb.ToString();
    }
  }
}
