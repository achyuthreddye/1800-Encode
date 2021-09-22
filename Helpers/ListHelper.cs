using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
  public static class Helper
  {
    public static List<string>
    ItemsInPresentDictionary(List<string> inputList, string[] dictionaryArray)
    {
      List<string> dictionaryList = new List<string>(dictionaryArray);
      List<string> cleanedList = new List<string>();
      foreach (string item in inputList)
      {
        if (dictionaryList.Contains(item)) cleanedList.Add(item);
      }
      return cleanedList;
    }

    public static string
    removeAllPunctuationsApartFromPeriod(string inputString)
    {
      var sb = new StringBuilder();

      foreach (char c in inputString)
      {
        if (!char.IsPunctuation(c) || c.ToString() == ".") sb.Append(c);
      }
      string finalOut = sb.ToString();
      return finalOut;
    }

    public static List<string>
    CombineListAtGivenIndex(List<string> list1, Hashtable charItem)
    {
      List<string> combinedList = new List<string>();

      foreach (string item in list1)
      {
        string intermediateString = item;
        foreach (DictionaryEntry item1 in charItem)
        {
          intermediateString =
              intermediateString
                  .Insert(int.Parse(item1.Key.ToString()),
                  item1.Value.ToString());
        }
        combinedList.Add(intermediateString);
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
