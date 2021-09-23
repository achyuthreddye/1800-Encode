using System.IO;
using System.Collections.Generic;

namespace Dictionary
{
  public static class DictionaryData
  {
    public static string[] ReadDataFromTextFile()
    {
      var path = System.IO.Directory.GetCurrentDirectory();
      path = Path.Combine(path, "dictionary.txt");
      string[] lines = File
              .ReadAllLines(path);
      return lines;
    }
    public static void WriteDatatoTextFile(string textTobeAdded)
    {
      var path = System.IO.Directory.GetCurrentDirectory();
      path = Path.Combine(path, "dictionary.txt");
      using StreamWriter file = File.AppendText(path);
      string[] lines = ReadDataFromTextFile();
      List<string> linesInDictionary = new List<string>(lines);
      if (!linesInDictionary.Contains(textTobeAdded))
      {
        file.WriteLine(textTobeAdded);

      }

    }
  }
}
