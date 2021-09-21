# 1800-Encode

## Problem statement

- Should try to replace all the given phone numbers with the possible words in the dictionary.
- A single digit can be replaced if a there is no match.
- Consecutive numbers cannot be left as it is.

## Running the app

This is a command line application:

- **Choosing the available options in the 🪣 list **

## Running the app using the commands from the Interactive prompt

```bash
1. dotnet run --project ConsoleApp/ConsoleApp.csproj
```

## 🪣 List of Options Available

Users can interact with the Console App with the following options:

- **1**: `encode your phone number ` will display all the possible words in the dictionary.

- **2**: `To view all the words in the dictionary` will display all the words in the dictionary.

- **3**: `Adding a word to the dictionary` will add a word to the dictionary.

- **4**: `quit` will exit from the app.

## Unit testing the individual components of the app.

### Testing the encode component.

```bash
1. dotnet test EncodeTest/EncodeTest.csproj
```

### Testing the dictionary component.

```bash
1. dotnet test DictionaryTest/DictionaryTest.csproj
```

### Testing the Helpers component.

```bash
1. dotnet test HelperTest/HelperTest.csproj
```
