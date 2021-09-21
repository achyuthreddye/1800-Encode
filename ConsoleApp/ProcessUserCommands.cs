namespace ConsoleApp
{
  public static class ProcessUserCommands
  {
    public static void ProcessIn()
    {
      string input;
      System
         .Console
         .WriteLine("\nEnter the following option that is needed \n 1--> Encode your Phone number 📞 based on the current dictionary 📚  of words \n 2--> View 👀 all the words in the dictionary📚  \n 3--> Not satisified 😞 with the current words in the dictionary📚 .🪛🔩Customize your dictionary 📚 by adding a word 😎 of your choice  \n 4--> 🛑 quit ");

      input = System.Console.ReadLine();
      switch (input.ToLower())
      {
        case "1":
          {
            Wrapper.EncodePhone();
            break;
          }
        case "2":
          {
            Wrapper.viewDictionary();
            break;
          }
        case "3":
          {
            Wrapper.addToDictionary();
            break;
          }
        case "4":
          {
            System.Console.WriteLine("👋 Bye!!!, We will meet soon !!");
            return;
          }
        default:
          {
            System
                .Console
                .WriteLine("Please 🥺 enter the valid option from the 🪣list ");
            ProcessUserCommands.ProcessIn();
            break;
          }
      }
    }
  }
}
