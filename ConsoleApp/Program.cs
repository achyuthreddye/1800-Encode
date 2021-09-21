using System.IO;
namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var path = Path.Combine(Directory.GetCurrentDirectory(), "dictionary.txt");
      System.Console.WriteLine("line1");
      System.Console.WriteLine(path);
      System.Console.WriteLine("line1");

      System
          .Console
          .WriteLine("\n🙏 Hello!!\nNow list your phone numbers 📞 using letters \n ");
      ProcessUserCommands.ProcessIn();
    }
  }
}
