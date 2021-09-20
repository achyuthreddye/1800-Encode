using System.Collections.Generic;

namespace Helpers
{
  public static class Helper
  {
    public static List<string>
    CombineList(List<string> list1, char charItem)
    {
      List<string> combinedList = new List<string>();
      foreach (string item in list1)
      {
        combinedList.Add(item + charItem);
      }
      return combinedList;
    }

    public static List<string>
    CombineListBasedOnDictionary(
        List<string> List1,
        char[] charList,
        string[] dictionaryList
    )
    {
      List<string> combinedList = new List<string>();

      // TODO: Can be optimized here instead of the three loops
      if (List1.Count == 0)
      {
        foreach (char item in charList)
        {
          foreach (string phrase in dictionaryList)
          {
            if (
                phrase.ToString().StartsWith(item) &&
                !combinedList.Contains(phrase)
            )
            {
              combinedList.Add(item.ToString());
            }
          }
        }
      }
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
