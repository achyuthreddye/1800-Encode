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

      while (number != "" && skippedCount <= 1)
      {
        int index = int.Parse(number[0].ToString());
        char[] charArr1 = phoneCoded[index].ToCharArray();

        if (phoneCoded[index] == "")
        {
          skippedCount += 1;
          number = number.Remove(0, 1);
        }
        else
        {
          combinedList =
              Helper
                  .CombineListBasedOnDictionary(combinedList,
                  charArr1,
                  dictData);
          number = number.Remove(0, 1);
        }
      }
      if (skippedCount > 1) return new List<string>();

      return combinedList;
    }
  }
}
