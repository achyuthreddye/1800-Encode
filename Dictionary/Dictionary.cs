using System.IO;
using System.Threading.Tasks;

namespace Dictionary
{
  public static class DictionaryData
  {
    public static string[] readDataFromTextFile()
    {
      // TODO: implement the relative path 
      string[] lines = File
              .ReadAllLines(@"/Users/achyuthreddy/Desktop/js projects/everest_coding_assignments/1800_coding/dictionary.txt");
      return lines;
    }
    public static async Task writeDatatoTextFile()
    {
      using StreamWriter file = new("dictionary123.txt");
      string text =
            "A class is the most powerful data type in C#. Like a structure, " +
            "a class defines the data and behavior of the data type. ";

      await file.WriteLineAsync(text);

    }
  }
}
