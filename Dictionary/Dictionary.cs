using System.IO;
using System.Collections.Generic;

namespace Dictionary
{
  public static class DictionaryData
  {
    public static string[] ReadDataFromTextFile()
    {


      string[] lines = File
              .ReadAllLines("dictionary.txt");
      return lines;
    }
    public static void WriteDatatoTextFile(string textTobeAdded)
    {
      using StreamWriter file = File.AppendText("dictionary.txt");
      string[] lines = ReadDataFromTextFile();
      List<string> linesInDictionary = new List<string>(lines);
      if (!linesInDictionary.Contains(textTobeAdded))
      {
        file.WriteLine(textTobeAdded);

      }

    }
  }
}
