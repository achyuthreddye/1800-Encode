namespace ConsoleApp
{
  public static class ProcessUserCommands
  {
    public static void ProcessIn()
    {
      string input;
      System
         .Console
         .WriteLine("\nEnter the following option that is needed \n 1--> Encode your Phone number 📞 based on the current dictionary 📚  of words \n 2--> View 👀 all the words in the dictionary📚  \n 3--> Not satisified 😞 with the current words in the dictionary📚 .🪛Customize🔩 your dictionary 📚 by adding a word 😎 of your choice  \n 4--> Encode all the Phone Numbers📞 in your text file 📚 \n 5--> 🛑 quit ");

      input = System.Console.ReadLine();
      switch (input.ToLower())
      {
        case "1":
          {
            System.Console
          .WriteLine("Please enter the phone number that has to encoded");
            string inputPhNo = System.Console.ReadLine();
            Wrapper.EncodePhone(inputPhNo);
            break;
          }
        case "2":
          {
            Wrapper.ViewDictionary();
            break;
          }
        case "3":
          {
            Wrapper.AddToDictionary();
            break;
          }
        case "4":
          {
            System.Console.WriteLine("Please enter the valid input file📚 along with .txt extension");
            string inputFile = System.Console.ReadLine();
            FileInput.EncodePhNoFromFile(inputFile);
            break;
          }
        case "5":
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
      ProcessUserCommands.ProcessIn();
    }
  }
}
