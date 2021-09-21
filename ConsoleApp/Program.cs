using Encode;
using System.Collections.Generic;

namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      EncodePhone encode = new EncodePhone();
      List<string> abc = encode.encodePhNo("22055");
      System.Console.WriteLine(abc.Count);
      foreach (var item in abc)
      {
        System.Console.WriteLine(item);

      }
      ProcessUserCommands.ProcessIn();




    }
  }
}
