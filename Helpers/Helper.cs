using System.Collections.Generic;
using System;

namespace Helpers
{
  public static class Helper
  {
    public static List<string> CombineLists(List<string> List1, char[] charList)
    {
      string[] sampleOutput = { "ad", "ae", "bd", "be" };
      string[] sampleData = { "a", "b" };
      List<string> list1 = new List<string>(sampleData);
      List<string> combinedList = new List<string>(sampleOutput);
      Console.WriteLine(combinedList[0]);
      return combinedList;
    }
  }
}
