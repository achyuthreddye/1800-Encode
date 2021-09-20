using System.Collections.Generic;
using Encode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

      CollectionAssert
          .AreEqual(encode.encodePhNo("2255"), ExpectedOutputList);
    }

    [TestMethod]
    public void TestToEncodeWithOneReplacement()
    {
      EncodePhone encode = new EncodePhone();
      string[] sampleOutput = { "ball", "call" };
      List<string> ExpectedOutputList = new List<string>(sampleOutput);

      CollectionAssert
          .AreEqual(encode.encodePhNo("22055"), ExpectedOutputList);
    }

    [TestMethod]
    public void TestToEncodeWithMoreThanOneReplacement()
    {
      EncodePhone encode = new EncodePhone();
      List<string> ExpectedOutputList = new List<string>();
      CollectionAssert
                .AreEqual(encode.encodePhNo("220055"), new List<string>());
    }
  }
}
