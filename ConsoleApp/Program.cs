namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length != 0 && args[0] != " ")
      {
        FileInput.EncodePhNoFromFile(args[0]);
        return;
      }

      System
          .Console
          .WriteLine("\n🙏 Hello!!\nNow list your phone numbers 📞 using letters \n ");
      ProcessUserCommands.ProcessIn();
    }
  }
}
