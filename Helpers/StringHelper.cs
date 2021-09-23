using System.Text;
using System;

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
    public static bool IsConsecutiveNonPhoneEncoded(string number, string[] phoneCoded)
    {
      bool isPresent = false;
      for (int i = 0; i < number.Length; i++)
      {
        if (Char.IsPunctuation(number[i]))
        {
          continue;
        }
        int index = int.Parse(number[i].ToString());
        int nextIndex = (i == number.Length - 1 || number[i + 1].ToString() == ".") ? -1 : int.Parse(number[i + 1].ToString());

        if (phoneCoded[index] == " ")
        {
          if (nextIndex != -1 && phoneCoded[nextIndex] == " ")
          {
            isPresent = true;
            break;
          }
        }
      }
      return isPresent;
    }
  }
}
