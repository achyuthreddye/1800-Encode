using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encode;
using System.Collections.Generic;

namespace EncodeTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestToEncodeWithoutReplacement()
    {
      EncodePhone encode = new EncodePhone();
      string[] sampleOutput = { "ball", "call" };
      List<string> ExpectedOutputList = new List<string>(sampleOutput);

      CollectionAssert.AreEqual(encode.encodePhNo("2255"), ExpectedOutputList);

    }
    [TestMethod]
    public void TestToEncodeWithReplacement()
    {
      EncodePhone encode = new EncodePhone();
      string[] sampleOutput = { "ball", "call" };
      List<string> ExpectedOutputList = new List<string>(sampleOutput);

      CollectionAssert.AreEqual(encode.encodePhNo("22055"), ExpectedOutputList);

    }
  }
}
