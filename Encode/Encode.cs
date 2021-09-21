﻿using System.Collections;
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

    public List<string> encodePhNo(string number)
    {
      number = Helper.removeAllPunctuationsApartFromPeriod(number);

      List<string> combinedList = new List<string>();
      string[] dictData = DictionaryData.readDataFromTextFile();
      bool consecutiveRepeatedDigits = false;

      Hashtable toBeReplaced = new Hashtable();

      for (int i = 0; i < number.Length; i++)
      {
        System.Console.WriteLine(i);
        System.Console.WriteLine(number[i]);

        if (consecutiveRepeatedDigits) break; //redundant

        if (number[i].ToString() == ".")
        {
          System.Console.WriteLine("enterign tej dot");
          toBeReplaced.Add(i, "-");
          continue;
        }

        int index = int.Parse(number[i].ToString());

        int nextIndex =
            i == number.Length - 1
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
          System.Console.WriteLine("Inside the else block" + i);
          char[] charrArr =
              phoneCoded[int.Parse(number[i].ToString())]
                  .ToCharArray();
          combinedList =
              Helper
                  .CombineListBasedOnDictionary(combinedList,
                  charrArr,
                  dictData);
        }
        System.Console.WriteLine(i + "at ending");
      }

      if (consecutiveRepeatedDigits) return new List<string>();
      combinedList = Helper.ItemsInPresentDictionary(combinedList, dictData);
      if (toBeReplaced.Count >= 1)
      {
        List<string> combinedListIndex = Helper
            .CombineListAtGivenIndex(combinedList, toBeReplaced);
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
