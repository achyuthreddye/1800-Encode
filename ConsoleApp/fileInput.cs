using System;
using System.IO;

namespace ConsoleApp
{
  public static class FileInput
  {
    public static void EncodePhNoFromFile(string fileName)
    {

      if (File.Exists(fileName))
      {
        Console.WriteLine(" ð Hello!! \n Encoding all the phone numbers ð in the input file given ð ");
        string[] lines = File.ReadAllLines(fileName);
        foreach (string phNo in lines)
        {
          Wrapper.EncodePhone(phNo);
        }
        return;
      }
      Console.WriteLine("ð Hello!! \n File ð does notð« ð  exists");
    }
  }
}
