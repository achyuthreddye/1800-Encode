using System;
using System.Collections.Generic;
using Encode;

namespace ConsoleApp
{
  public static class ProcessUserCommands
  {
    public static void ProcessIn(string input)
    {
      if (input == "encode")
      {
        EncodePhone encode = new EncodePhone();
        Console
            .WriteLine("Please enter the phone number that has to encoded");
        string inputPhNo = Console.ReadLine();
        List<string> encodedWords = new List<string>();
        encodedWords = encode.encodePhNo(inputPhNo);
        foreach (string item in encodedWords)
        {
          Console.WriteLine(item);
        }
      }
    }
  }
}
