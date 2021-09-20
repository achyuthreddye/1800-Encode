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
      string[] sampleData = { "a", "b", "c" };
      string[] sampleOutput = { "a0", "b0", "c0" };
      List<string> list1 = new List<string>(sampleData);
      List<string> expectedOutput = new List<string>(sampleOutput);
      List<string> actualOutput = new List<string>(sampleOutput);
      CollectionAssert.AreEqual(actualOutput, expectedOutput);

    }
    [TestMethod]
    public void TestToCombineTwoListsBasedOnDictionary()
    {
      string[] dictionary = { "callme", "call", "ball", "apache", "hyundai", "zebra" };
      string[] sampleData = { "a", "b", "c" };
      string[] sampleOutput = { "ba", "ca" };
      string tobeCombined = "abc";
      char[] charArr = tobeCombined.ToCharArray();

      List<string> list1 = new List<string>(sampleData);
      List<string> ExpectedOutputList = new List<string>(sampleOutput);
      List<string> actualOutputList = Helper.CombineListBasedOnDictionary(list1, charArr, dictionary);

      CollectionAssert.AreEqual(actualOutputList, ExpectedOutputList);

    }
  }
}
