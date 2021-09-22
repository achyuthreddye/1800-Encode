using System.Text;

namespace Helpers
{
  public static class StringHelpers
  {
    public static string
    RemoveAllPunctuationsApartFromPeriod(string inputString)
    {
      var sb = new StringBuilder();

      foreach (char c in inputString)
      {
        if (!char.IsPunctuation(c) || c.ToString() == ".") sb.Append(c);
      }
      string finalOut = sb.ToString();
      return finalOut;
    }
  }
}
