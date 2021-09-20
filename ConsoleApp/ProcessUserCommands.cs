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
            Wrapper.EncodePhone();
            break;
          }
        case "dictionaryview":
          {
            Wrapper.viewDictionary();
            break;
          }
        case "addworddictionary":
          {
            Wrapper.addToDictionary();
            break;
          }
      }
    }
  }
}
