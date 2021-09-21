using System.Collections.Generic;
using System.Linq;
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


      bool isEqual =
          Enumerable
              .SequenceEqual(ExpectedOutputList.OrderBy(e => e),
              ActualOutputList.OrderBy(e => e));
      Assert.IsTrue(isEqual);
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


      bool isEqual =
          Enumerable
              .SequenceEqual(ExpectedOutputList.OrderBy(e => e),
              ActualOutputList.OrderBy(e => e));
      Assert.IsTrue(isEqual);
    }


    // [TestMethod]
    // public void TestToEncodeWithPeriod()
    // {
    //   EncodePhone encode = new EncodePhone();
    //   string[] encoded = { "ba-ll", "ca-ll" };
    //   List<string> ExpectedOutputList = new List<string>(encoded);
    //   List<string> ActualOutputList = encode.encodePhNo("22.55");
    //   bool isEqual =
    //       Enumerable
    //           .SequenceEqual(ExpectedOutputList.OrderBy(e => e),
    //           ActualOutputList.OrderBy(e => e));
    //   Assert.IsTrue(isEqual);
    // }
  }
}
