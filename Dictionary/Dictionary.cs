﻿
namespace Dictionary
{
  public static class DictionaryData
  {
    public static string[] readDataFromTextFile()
    {
      // string[] dictionary =
      // { "callme", "call", "ball", "apache", "hyundai", "zebra" };
      string[] lines = System.IO.File.ReadAllLines(@"/Users/achyuthreddy/Desktop/js projects/everest_coding_assignments/1800_coding/dictionary.txt");
      return lines;

    }
  }
}

