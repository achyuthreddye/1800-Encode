using System;
using System.Collections.Generic;
using Encode;
using Dictionary;

namespace ConsoleApp
{
  public static class ProcessUserCommands
  {
    public static void ProcessIn(string input)
    {
      switch (input)
      {
        case "encode":
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
            if (encodedWords.Count == 0)
            {
              Console.WriteLine("there are no possible encoding for " + inputPhNo + "  in the dictionary. ");
            }
            break;
          }
        case "dictionaryview":
          {
            string[] dicData = DictionaryData.readDataFromTextFile();
            Console.WriteLine("The words in the dictionary are");
            foreach (string item in dicData)
            {
              Console.WriteLine(item);

            }
            break;
          }
        case "addworddictionary":
          {
            Console.WriteLine("Please enter the word that has to added to the dictionary");
            string wordTobeAdded = Console.ReadLine();
            DictionaryData.writeDatatoTextFile(wordTobeAdded);
            break;
          }
      }
    }
  }
}
