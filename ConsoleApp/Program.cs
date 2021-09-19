using System.Threading.Tasks;
using Dictionary;

namespace ConsoleApp
{
  class Program
  {
    static async Task Main(string[] args)
    {
      string[] abc = DictionaryData.readDataFromTextFile();


      await DictionaryData.writeDatatoTextFile("masaratti45");

      string[] abc1 = DictionaryData.readDataFromTextFile();

    }
  }
}
