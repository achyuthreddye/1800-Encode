using System;
using System.IO;

namespace ConsoleApp
{
  public static class FileInput
  {
    public static void encodePhNoFromFile(string fileName)
    {

      if (File.Exists(fileName))
      {
        Console.WriteLine(" 🙏 Hello!! \n Encoding all the phone numbers 📞 in the input file given 📚 ");
        string[] lines = File.ReadAllLines(fileName);
        foreach (string phNo in lines)
        {
          Wrapper.EncodePhone(phNo);
        }
        return;
      }

      Console.WriteLine("🙏 Hello!! \n File 📚 does not🚫 🔍  exists");
    }
  }
}
