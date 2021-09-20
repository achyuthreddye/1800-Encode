using System;
using System.Collections.Generic;
using Dictionary;
using Encode;

namespace ConsoleApp
{
  public static class Wrapper
  {
    public static void EncodePhone()
    {
      EncodePhone encode = new EncodePhone();
      Console
          .WriteLine("Please enter the phone number that has to encoded");
      string inputPhNo = Console.ReadLine();
      List<string> encodedWords = new List<string>();
      encodedWords = encode.encodePhNo(inputPhNo);

      if (encodedWords.Count == 0)
      {
        Console
            .WriteLine("there are no possible encoding for " +
            inputPhNo +
            "  in the dictionary. ");
      }
      else
      {
        Console.WriteLine("The possible words could be replaced with the number  " + inputPhNo);
        foreach (string item in encodedWords)
        {
          Console.WriteLine(item);
        }
      }
      ProcessUserCommands.ProcessIn();
    }

    public static void viewDictionary()
    {
      string[] dicData = DictionaryData.readDataFromTextFile();
      Console.WriteLine("The words in the dictionary are");
      foreach (string item in dicData)
      {
        Console.WriteLine(item);
      }
      ProcessUserCommands.ProcessIn();
    }

    public static void addToDictionary()
    {
      Console
          .WriteLine("Please enter the word that has to added to the dictionary");
      string wordTobeAdded = Console.ReadLine();
      DictionaryData.writeDatatoTextFile(wordTobeAdded);
      Console
          .WriteLine("Added the word to the dictionary. Successfully!!!!");
      ProcessUserCommands.ProcessIn();
    }
  }
}
