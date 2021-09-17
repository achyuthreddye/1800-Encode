using System.Collections.Generic;

namespace Helpers
{
  public static class Helper
  {
    public static List<string>
    CombineLists(List<string> List1, char[] charList)
    {
      List<string> combinedList = new List<string>();
      foreach (string item in List1)
      {
        foreach (char charItem in charList)
        {
          combinedList.Add(item + charItem);
        }
      }

      return combinedList;
    }
  }
}
