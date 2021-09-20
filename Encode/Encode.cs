using System.Collections;
using System.Collections.Generic;
using Dictionary;
using Helpers;

namespace Encode
{
  public class EncodePhone
  {
    // TODO: should this be stored somewhere else
    static string[]
        phoneCoded =
        {
                "",
                "",
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqrs",
                "tuv",
                "wxyz"
            };

    public List<string> encodePhNo(string number)
    {
      // TODO: should this be static
      List<string> combinedList = new List<string>();
      string[] dictData = DictionaryData.readDataFromTextFile();
      bool consecutiveRepeatedDigits = false;

      Hashtable numberNames = new Hashtable();

      for (int i = 0; i < number.Length; i++)
      {
        if (consecutiveRepeatedDigits) break;

        int index = int.Parse(number[i].ToString());
        int nextIndex =
            i == number.Length - 1
                ? int.Parse(number[i].ToString())
                : -1;

        if (phoneCoded[index] == "")
        {
          if (nextIndex != -1 && phoneCoded[nextIndex] == "")
          {
            consecutiveRepeatedDigits = true;
            break;
          }

          numberNames.Add(i, number[i]);
        }
        else
        {
          char[] charrArr =
              phoneCoded[int.Parse(number[i].ToString())]
                  .ToCharArray();
          combinedList =
              Helper
                  .CombineListBasedOnDictionary(combinedList,
                  charrArr,
                  dictData);
        }
      }
      System.Console.WriteLine("Int eh afd");

      foreach (DictionaryEntry item in numberNames)
      {
        System
            .Console
            .WriteLine("In the foreach " +
            item.Key +
            "and the value is " +
            item.Value);
      }
      if (numberNames.Count >= 1)
      {
        return Helper.CombineListAtGivenIndex(combinedList, numberNames);

      }


      if (consecutiveRepeatedDigits) return new List<string>();

      return combinedList;
    }
  }
}
