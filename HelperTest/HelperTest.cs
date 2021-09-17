using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Helpers;
namespace HelperTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestToCombineTwoLists()
    {
      string[] sampleData = { "a", "b" };
      string[] sampleOutput = { "ad", "ae", "bd", "be" };
      string tobeCombined = "de";
      char[] charArr = tobeCombined.ToCharArray();

      List<string> list1 = new List<string>(sampleData);
      List<string> ExpectedOutputList = new List<string>(sampleOutput);
      List<string> actualOutputList = Helper.CombineLists(list1, charArr);

      CollectionAssert.AreEqual(actualOutputList, ExpectedOutputList);

    }
  }
}
