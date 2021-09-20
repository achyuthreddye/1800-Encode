using Encode;
using System.Collections.Generic;

namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      ProcessUserCommands.ProcessIn();
      EncodePhone encode = new EncodePhone();
      List<string> abc = encode.encodePhNo("220505");
      foreach (var item in abc)
      {
        System.Console.WriteLine(item);

      }

    }
  }
}
