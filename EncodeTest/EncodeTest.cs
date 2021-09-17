using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encode;
using System.Collections.Generic;

namespace EncodeTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      EncodePhone encode = new EncodePhone();
      string[] sampleOutput = { "ba", "ca" };
      List<string> ExpectedOutputList = new List<string>(sampleOutput);

      CollectionAssert.AreEqual(encode.enocdeDistionary(), ExpectedOutputList);

    }
  }
}
