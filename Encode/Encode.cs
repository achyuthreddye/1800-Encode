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

    public List<string> EncodePhNo(string number, string[] dictData)
    {
      number = StringHelpers.RemoveAllPunctuationsApartFromPeriod(number);
      List<string> combinedList = new List<string>();
      bool consecutiveRepeatedDigits = StringHelpers.IsConsecutiveNonPhoneEncoded(number, phoneCoded);
      Hashtable toBeReplaced = new Hashtable();

      if (consecutiveRepeatedDigits) { return new List<string>(); }

      for (int i = 0; i < number.Length; i++)
      {
        if (number[i].ToString() == ".")
        {
          toBeReplaced.Add(i, "-");
          continue;
        }
        int index = int.Parse(number[i].ToString());

        if (phoneCoded[index] == " ")
        {
          toBeReplaced.Add(i, number[i]);
        }
        else
        {
          char[] charrArr = phoneCoded[int.Parse(number[i].ToString())].ToCharArray();
          combinedList = Helper.CombineListBasedOnDictionary(combinedList, charrArr, dictData);
        }
      }
      combinedList = Helper.ItemsInPresentDictionary(combinedList, dictData);
      if (toBeReplaced.Count >= 1)
      {
        List<string> combinedListIndex = Helper.CombineListAtGivenIndex(combinedList, toBeReplaced);

        return combinedListIndex;
      }
      else
        return combinedList;
    }
  }
}
