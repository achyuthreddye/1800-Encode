using System.Collections.Generic;
using Helpers;
using Dictionary;
using System;
namespace Encode
{
  public class EncodePhone
  {
    static string[]
        dictionary =
        { "callme","call", "ball", "apache", "hyundai", "zebra" };

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
      foreach (var item in dictData)
      {
        Console.WriteLine("dictData");
        Console.WriteLine(item);

      }
      //   await DictionaryData.writeDatatoTextFile();
      while (number != "")
      {
        int index = int.Parse(number[0].ToString());
        char[] charArr1 = phoneCoded[index].ToCharArray();

        combinedList =
            Helper
                .CombineListBasedOnDictionary(combinedList,
                charArr1,
                dictionary);
        number = number.Remove(0, 1);
      }
      //   TODO: delete the items in the list that contains only startswith condition

      return combinedList;
    }
  }
}
