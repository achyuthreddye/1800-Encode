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

      string x;
      System.Console.WriteLine("Enter the the following option that is needed");

      // using the method
      x = System.Console.ReadLine();

      ProcessUserCommands.ProcessIn(x);
      return Task.CompletedTask;
    }
  }
}
