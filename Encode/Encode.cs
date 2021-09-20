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
      List<string> combinedList = new List<string>();
      string[] dictData = DictionaryData.readDataFromTextFile();
      int skippedCount = 0;
      int tobeReplaced;
      for (int i = 0; i < number.Length; i++)
      {
        if (skippedCount > 1) break;
        tobeReplaced = i;
        int index = int.Parse(number[i].ToString());
        if (phoneCoded[index] == "")
        {
          skippedCount += 1;
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

      if (skippedCount > 1) return new List<string>();

      return combinedList;
    }
  }
}
