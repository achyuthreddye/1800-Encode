namespace ConsoleApp
{
  public static class ProcessUserCommands
  {
    public static void ProcessIn()
    {
      string input;
      System
          .Console
          .WriteLine("\nEnter the following option that is needed \n 1--> encode \n 2--> viewdictionary \n 3--> addwordtodictionary ");
      input = System.Console.ReadLine();
      switch (input.ToLower())
      {
        case "encode":
          {
            Wrapper.EncodePhone();
            break;
          }
        case "viewdictionary":
          {
            Wrapper.viewDictionary();
            break;
          }
        case "addwordtodictionary":
          {
            Wrapper.addToDictionary();
            break;
          }
        case "quit":
          {
            return;
          }
        default:
          {
            System
                .Console
                .WriteLine("Please enter the valid option that has to be performed");
            break;
          }
      }
    }
  }
}
