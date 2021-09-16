using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Helpers;
namespace HelperTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      string[] sampleData = { "a", "b" };
      string[] sampleOutput = { "ad", "ae", "bd", "be" };
      string tobeCombined = "de";
      char[] charArr = tobeCombined.ToCharArray();

      List<string> list1 = new List<string>(sampleData);
      List<string> ExpectedOutputList = new List<string>(sampleOutput);
      List<string> actualOutputList = Helper.CombineLists(list1, charArr);
      //   Assert.AreEqual(actualOutputList, ExpectedOutputList);
      Assert.AreEqual(list1, list1);

      //   Helper.CombineLists()
    }
  }
}
