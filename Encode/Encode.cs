using System.Collections.Generic;
using Helpers;

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
