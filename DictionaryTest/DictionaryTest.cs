using Dictionary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DictionaryTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestGettingAllData()
    {
      string[] dictionary =
      { "callme", "call", "ball", "apache", "hyundai", "zebra" };
      string[] actualOutputList = DictionaryData.readDataFromTextFile();
      CollectionAssert.AreEqual(actualOutputList, dictionary);
    }
  }
}
