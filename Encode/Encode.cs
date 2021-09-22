using System.Collections;
using System.Collections.Generic;
using Helpers;

namespace Encode
{
  public class EncodePhone
  {
    // TODO: should this be stored somewhere else
    static string[]
        phoneCoded =
        {
                " ",
                " ",
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqrs",
                "tuv",
                "wxyz"
            };

    public List<string> encodePhNo(string number, string[] dictData)
    {
      number = Helper.removeAllPunctuationsApartFromPeriod(number);

      List<string> combinedList = new List<string>();
      bool consecutiveRepeatedDigits = false;

      Hashtable toBeReplaced = new Hashtable();

      for (int i = 0; i < number.Length; i++)
      {
        if (consecutiveRepeatedDigits) break; //redundant

        if (number[i].ToString() == ".")
        {
          toBeReplaced.Add(i, "-");
          continue;
        }

        int index = int.Parse(number[i].ToString());

        int nextIndex =
            (i == number.Length - 1 || number[i + 1].ToString() == ".")
                ? -1
                : int.Parse(number[i + 1].ToString());

        if (phoneCoded[index] == " ")
        {
          if (nextIndex != -1 && phoneCoded[nextIndex] == " ")
          {
            consecutiveRepeatedDigits = true;
            break;
          }

          toBeReplaced.Add(i, number[i]);
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

      if (consecutiveRepeatedDigits) return new List<string>();
      combinedList =
          Helper.ItemsInPresentDictionary(combinedList, dictData);
      if (toBeReplaced.Count >= 1)
      {
        List<string> combinedListIndex =
            Helper.CombineListAtGivenIndex(combinedList, toBeReplaced);
        foreach (string item in combinedListIndex)
        {
          System.Console.WriteLine(item);
        }

        return combinedListIndex;
      }
      else
        return combinedList;
    }
  }
}
