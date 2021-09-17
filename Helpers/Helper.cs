using System.Collections.Generic;

namespace Helpers
{
  public static class Helper
  {
    public static List<string>
    CombineListBasedOnDictionary(
        List<string> List1,
        char[] charList,
        string[] dictionaryList
    )
    {
      List<string> combinedList = new List<string>();
      // TODO: Can be optimized here instead of the three loops
      foreach (string item in List1)
      {
        foreach (char charItem in charList)
        {
          foreach (string phrase in dictionaryList)
          {
            if (
                phrase.StartsWith(item + charItem) &&
                !combinedList.Contains(item + charItem)
            )
            {
              combinedList.Add(item + charItem);
            }
          }
        }
      }


      return combinedList;
    }
  }
}
