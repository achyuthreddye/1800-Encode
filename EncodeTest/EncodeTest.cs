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
      string[] sampleOutput = { "ba0ll", "ca0ll" };
      List<string> ExpectedOutputList = new List<string>(sampleOutput);
      List<string> ActualOutputList = encode.encodePhNo("22055");
      // Assert.IsTrue(ExpectedOutputList.SequenceEqual(ActualOutputList));
      // CollectionAssert
      //     .AreEqual(ActualOutputList, ExpectedOutputList);
    }

    [TestMethod]
    public void TestToEncodeWithConsecutiveNosWithNosReplacement()
    {
      EncodePhone encode = new EncodePhone();
      List<string> ExpectedOutputList = new List<string>();
      List<string> ActualOutputList = encode.encodePhNo("220055");
      // CollectionAssert
      //           .AreEqual(ActualOutputList, ExpectedOutputList);
      CollectionAssert.AreEqual(ExpectedOutputList, ActualOutputList);
    }

    // [TestMethod]
    // public void TestToEncodeWithMoreThanOneReplacementNonContinuously()
    // {
    //   EncodePhone encode = new EncodePhone();
    //   string[] encoded = { "ba0101", "ca0101" };
    //   List<string> ExpectedOutputList = new List<string>(encoded);
    //   List<string> actualOutputList = encode.encodePhNo("220505");
    //   CollectionAssert
    //             .AreEqual(ExpectedOutputList, actualOutputList);
    // }
    // [TestMethod]
    // public void TestToEncodeWithPeriod()
    // {
    //   EncodePhone encode = new EncodePhone();
    //   string[] encoded = { "ba-11", "ca-11" };
    //   List<string> ExpectedOutputList = new List<string>(encoded);
    //   List<string> actualOutputList = encode.encodePhNo("22.55");
    //   CollectionAssert
    //             .AreEqual(ExpectedOutputList, actualOutputList);
    // }
  }
}
