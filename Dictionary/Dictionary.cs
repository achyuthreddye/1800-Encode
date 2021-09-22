using System.IO;
using System.Collections.Generic;

namespace Dictionary
{
  public static class DictionaryData
  {
    public static string[] readDataFromTextFile()
    {


      string[] lines = File
              .ReadAllLines("dictionary.txt");
      return lines;
    }
    public static void writeDatatoTextFile(string textTobeAdded)
    {
      using StreamWriter file = File.AppendText("dictionary.txt");
      string[] lines = readDataFromTextFile();
      List<string> linesInDictionary = new List<string>(lines);
      if (!linesInDictionary.Contains(textTobeAdded))
      {
        file.WriteLine(textTobeAdded);

      }

    }
  }
}
