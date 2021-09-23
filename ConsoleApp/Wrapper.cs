using System;
using System.Collections.Generic;
using Dictionary;
using Encode;

namespace ConsoleApp
{
  public static class Wrapper
  {
    public static void EncodePhone(string inputPhNo)
    {
      EncodePhone encode = new EncodePhone();

      List<string> encodedWords = new List<string>();
      string[] dictData = DictionaryData.ReadDataFromTextFile();
      encodedWords = encode.EncodePhNo(inputPhNo, dictData);

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
          Console.WriteLine(item.ToUpper());
        }
      }
    }

    public static void ViewDictionary()
    {
      string[] dicData = DictionaryData.ReadDataFromTextFile();
      Console.WriteLine("The words in the dictionary are");
      foreach (string item in dicData)
      {
        Console.WriteLine(item.ToUpper());
      }
    }

    public static void AddToDictionary()
    {
      Console
          .WriteLine("Please enter the word that has to added to the dictionary");
      string wordTobeAdded = Console.ReadLine();
      DictionaryData.WriteDatatoTextFile(wordTobeAdded);
      Console
          .WriteLine("Added the word to the dictionary. Successfully!!!!");
    }
  }
}
