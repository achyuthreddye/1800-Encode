using System.Collections.Generic;
using Dictionary;
using Helpers;

namespace Encode
{
  public class EncodePhone
  {
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

      while (number != "")
      {
        if (number[0].ToString() == "")
        {
          skippedCount += 1;
          number = number.Remove(0, 1);
        }
        else
        {


          int index = int.Parse(number[0].ToString());
          char[] charArr1 = phoneCoded[index].ToCharArray();

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
