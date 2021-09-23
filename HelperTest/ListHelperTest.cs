using System.Collections;
using System.Collections.Generic;
using Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelperTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestToCombineItemsAtGivenIndex()
    {
      string[] sampleData = { "call", "ball" };
      string[] sampleOutput = { "ca0ll", "ba0ll" };
      List<string> list1 = new List<string>(sampleData);
      List<string> expectedOutput = new List<string>(sampleOutput);
      Hashtable numberNames = new Hashtable();
      numberNames.Add(2, 0);

      List<string> actualOutput = Helper.CombineListAtGivenIndex(list1, numberNames);

      CollectionAssert.AreEqual(actualOutput, expectedOutput);
    }

    [TestMethod]
    public void TestToCombineTwoListsBasedOnDictionary()
    {
      string[] dictionary =
      { "callme", "call", "ball", "apache", "hyundai", "zebra" };
      string[] sampleData = { "a", "b", "c" };
      string[] sampleOutput = { "ba", "ca" };
      string tobeCombined = "abc";
      char[] charArr = tobeCombined.ToCharArray();
      List<string> list1 = new List<string>(sampleData);
      List<string> ExpectedOutputList = new List<string>(sampleOutput);

      List<string> actualOutputList = Helper.CombineListBasedOnDictionary(list1, charArr, dictionary);

      CollectionAssert.AreEqual(actualOutputList, ExpectedOutputList);
    }
    [TestMethod]
    public void TestToCombineTwoListsBasedOnDictionaryWihEmptyList()
    {
      string[] dictionary =
      { "callme", "call", "ball", "apache", "hyundai", "zebra" };
      string[] sampleOutput = { "a", "b", "c", "c" };
      string tobeCombined = "abc";
      char[] charArr = tobeCombined.ToCharArray();
      List<string> list1 = new List<string>();
      List<string> ExpectedOutputList = new List<string>(sampleOutput);

      List<string> actualOutputList = Helper.CombineListBasedOnDictionary(list1, charArr, dictionary);

      CollectionAssert.AreEqual(actualOutputList, ExpectedOutputList);
    }

    [TestMethod]
    public void TestItemsInPresentDictionary()
    {
      string[] dictionary =
      { "callme", "call", "ball", "apache", "hyundai", "zebra" };
      string[] inputData = { "ca", "ba", "ball", "call" };
      string[] expectedData = { "ball", "call" };
      List<string> list1 = new List<string>(inputData);
      List<string> ExpectedList = new List<string>(expectedData);

      List<string> actualOutputList = Helper.ItemsInPresentDictionary(list1, dictionary);

      CollectionAssert.AreEqual(actualOutputList, ExpectedList);
    }
  }
}
