using System.Collections.Generic;
using System.Linq;
using Encode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncodeTest
{
  [TestClass]
  public class UnitTest1
  {
    static string[] dictData = { "reddy", "hyundai", "ball", "call", "callme", "apple" };
    [TestMethod]
    public void TestToEncodeWithoutReplacement()
    {
      EncodePhone encode = new EncodePhone();
      string[] sampleOutput = { "ball", "call" };
      List<string> ExpectedOutputList = new List<string>(sampleOutput);
      CollectionAssert.AreEqual(encode.EncodePhNo("2255", dictData), ExpectedOutputList);
    }

    [TestMethod]
    public void TestToEncodeWithOneReplacement()
    {
      EncodePhone encode = new EncodePhone();
      string[] sampleOutput = { "ba0ll", "ca0ll" };
      List<string> ExpectedOutputList = new List<string>(sampleOutput);
      List<string> ActualOutputList = encode.EncodePhNo("22055", dictData);

      bool isEqual = Enumerable.SequenceEqual(ExpectedOutputList.OrderBy(e => e), ActualOutputList.OrderBy(e => e));
      Assert.IsTrue(isEqual);
    }

    [TestMethod]
    public void TestToEncodeWithConsecutiveNosWithNosReplacement()
    {
      EncodePhone encode = new EncodePhone();
      List<string> ExpectedOutputList = new List<string>();
      List<string> ActualOutputList = encode.EncodePhNo("220055", dictData);

      bool isEqual = Enumerable.SequenceEqual(ExpectedOutputList.OrderBy(e => e), ActualOutputList.OrderBy(e => e));
      Assert.IsTrue(isEqual);
    }

    [TestMethod]
    public void TestToEncodeWithPeriod()
    {
      EncodePhone encode = new EncodePhone();
      string[] encoded = { "ba-ll", "ca-ll" };
      List<string> ExpectedOutputList = new List<string>(encoded);
      List<string> ActualOutputList = encode.EncodePhNo("22.55", dictData);
      bool isEqual = Enumerable.SequenceEqual(ExpectedOutputList.OrderBy(e => e), ActualOutputList.OrderBy(e => e));
      Assert.IsTrue(isEqual);
    }
  }
}
