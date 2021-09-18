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
      //   await DictionaryData.writeDatatoTextFile();
      string[] actualOutputList = DictionaryData.readDataFromTextFile();
      CollectionAssert.AreEqual(actualOutputList, dictionary);
    }

    [TestMethod]
    public void TestWritingData()
    {
      //   Task abc = await DictionaryData.writeDatatoTextFile();
      //   Console.WriteLine("Achyuth");
      //   var myTask = Task.Run(() => DictionaryData.writeDatatoTextFile());
      //   await Task.WhenAll(myTask);
    }

  }
}
