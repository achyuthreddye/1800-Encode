using System.Collections.Generic;
using System.Threading.Tasks;
using Encode;


namespace ConsoleApp
{
  class Program
  {
    static Task Main(string[] args)
    {
      EncodePhone encodeMethod = new EncodePhone();
      List<string> listOfDictionary = new List<string>();
      ProcessUserCommands.ProcessIn();
      return Task.CompletedTask;
    }
  }
}
