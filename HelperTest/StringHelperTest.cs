using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;
namespace HelperTest
{
  public class UnitTest2
  {
    [TestMethod]
    public void TestToRemoveAllPunctuationAprtFromPeriod()
    {
      string inputString = "22.5&5";
      string expectedString = "22.55";

      string actualString = StringHelpers.RemoveAllPunctuationsApartFromPeriod(inputString);

      Assert.AreEqual(expectedString, actualString);

    }
    [TestMethod]
    public void TestToRemoveAllPunctuationAprtFromPeriod1()
    {
      string inputString = "22.5.5";
      string expectedString = "22.5.5";

      string actualString = StringHelpers.RemoveAllPunctuationsApartFromPeriod(inputString);

      Assert.AreEqual(expectedString, actualString);

    }

    [TestMethod]
    public void TestConsecutiveNonPhoneEncoded()
    {

    }
  }

}