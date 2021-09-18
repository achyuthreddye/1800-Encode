using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encode;
using System.Collections.Generic;

namespace EncodeTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestToCombineListsBasedDictionary()
    {
      EncodePhone encode = new EncodePhone();
      string[] sampleOutput = { "ball", "call" };
      List<string> ExpectedOutputList = new List<string>(sampleOutput);

      CollectionAssert.AreEqual(encode.encodePhNo("2255"), ExpectedOutputList);

    }
  }
}
