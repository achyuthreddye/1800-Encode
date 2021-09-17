using System.Collections.Generic;
using Helpers;
namespace Encode
{
  public class EncodePhone
  {
    // Helper.CombineListBasedOnDictionary();

    static string[] dictionary = { "callme", "call", "ball", "apache", "hyundai", "zebra" };
    static string[] sampleData = { "a", "b", "c" };
    static string[] sampleOutput = { "ba", "ca" };
    static string tobeCombined = "abc";
    static char[] charArr = tobeCombined.ToCharArray();

    static List<string> list1 = new List<string>(sampleData);
    List<string> ExpectedOutputList = new List<string>(sampleOutput);

    public List<string> enocdeDistionary()
    {

      List<string> combinedList = Helper.CombineListBasedOnDictionary(list1, charArr, dictionary);


      return combinedList;

    }

  }
}
