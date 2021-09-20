using System.Collections.Generic;
using System.Threading.Tasks;
using Dictionary;
using Encode;


namespace ConsoleApp
{
  class Program
  {
    static async Task Main(string[] args)
    {
      EncodePhone encodeMethod = new EncodePhone();
      List<string> listOfDictionary = new List<string>();
      listOfDictionary = encodeMethod.encodePhNo("22055");
      foreach (string item in listOfDictionary)
      {
        System.Console.WriteLine(item);

      }
      string[] abc = DictionaryData.readDataFromTextFile();
      await DictionaryData.writeDatatoTextFile("masaratti");
      string[] abc1 = DictionaryData.readDataFromTextFile();
    }
  }
}
