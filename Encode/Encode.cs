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

      string numberWithoutPunctuation = Helper.removeAllPunctuationsApartFromPeriod(number);



      List<string> combinedList = new List<string>();
      string[] dictData = DictionaryData.readDataFromTextFile();
      bool consecutiveRepeatedDigits = false;

      Hashtable toBeReplaced = new Hashtable();

      for (int i = 0; i < numberWithoutPunctuation.Length; i++)
      {
        if (numberWithoutPunctuation[i].ToString() == ".")
        {
          toBeReplaced.Add(i, "-");
          continue;
        }

        int index = int.Parse(numberWithoutPunctuation[i].ToString());
        int nextIndex =
            i == numberWithoutPunctuation.Length - 1
                ? -1
                : int.Parse(numberWithoutPunctuation[i].ToString());

        if (phoneCoded[index] == "")
        {
          if (nextIndex != -1 && phoneCoded[nextIndex] == "")
          {
            consecutiveRepeatedDigits = true;
            break;
          }

          toBeReplaced.Add(i, numberWithoutPunctuation[i]);
        }
        else
        {
          char[] charrArr =
              phoneCoded[int.Parse(numberWithoutPunctuation[i].ToString())]
                  .ToCharArray();
          combinedList =
              Helper
                  .CombineListBasedOnDictionary(combinedList,
                  charrArr,
                  dictData);
        }
      }

      if (toBeReplaced.Count >= 1)
      {
        return Helper
            .CombineListAtGivenIndex(combinedList, toBeReplaced);
      }

      if (consecutiveRepeatedDigits) return new List<string>();

      return combinedList;
    }
  }
}
