# C# Coding Challenge - Old Phone Pad

### Overview
This project emulates the behavior of an old mobile phone keypad, where users input letters by repeatedly pressing numeric keys.

# Method 
### OldPhonePad
`PhonePadController` is a C# class that emulates the behavior of an old mobile phone keypad, where users type letters by pressing numeric keys multiple times.

The features on this class using the method `OldPhonePad` must be:
- Converts numeric key sequences into text, similar to T9 input systems.
- Supports special keys:
  - `*` for backspace (deletes the last character).
  - `0` for space.
  - `#` to send the message (finish input).
- Handles repeated key presses to determine the correct letter.
- Uses a `Dictionary<char, string>` to map number keys to letters.

## How to use
You can use the static method `OldPhonePad(string input)` to convert a numeric string into text.
### Example
```csharp
string input = "44 33 555 555 666 0 444 777 666 66 0 7777 666 333 8 9 2 777 33 0 8 44 444 7777 0 444 7777 0 2 66 0 33 99 2 6 7 555 33#";
string output = PhonePadController.OldPhonePad(input);
Console.WriteLine(output); // HELLO IRON SOFTWARE THIS IS AN EXAMPLE
```
# How To Run
### Prerequisites
- Visual Studio 2022
- .NET 7.0.10 or later

## Steps to run
### 1. Clone Repo
`git clone https://github.com/jlavandier/OldPhonePadCodingChallenge.git`

### 2. Open the Solution 
- C# Coding Challenge - Old Pad Phone
### 3. Build the solution
- Right on solution name > Build Solution
### 4. Run the Project
- Press 'F5' or go to 'Debug > Start Debugging'
# Modifying Input
To test differents value on `Program.cs` you need to change the inputs values on `OldPhonePad("new string")`.

```csharp
Console.WriteLine(PhonePadController.OldPhonePad("222 2 22#")); // "CAB"
Console.WriteLine(PhonePadController.OldPhonePad("44 33 555 * 555 666#")); // "HELO"
Console.WriteLine(PhonePadController.OldPhonePad("444 777 666 66 0 7777 666 333 8 9 2 777 33#")); // "IRON SOFTWARE"

Console.WriteLine(PhonePadController.OldPhonePad("8 33 7777 8 444 66 4")); // Not return because # is missing
Console.WriteLine(PhonePadController.OldPhonePad("8 33 7777 8 444 66 4#")); // "TESTING"
```
# Unit Tests
I add a project destinated only for Unit Tests as a Visual Studio xUnit Test Project to verify the functionality of `OldPhonePad` Method. The test will be find in the project `TestProject` in the class `UnitTest1`.

### Prerequisites to run the Unit Tests
- xunit
- xunit.runner.visualstudio
- Microsoft.NET.Test.Sdk

# Running the Unit Tests
1. Build the Solution:
    - In Visual Studio solution name `Right Click` > `Build Solution` or press `Ctrl+Shift+B`.
2. Run the Tests:
    - In Visual Studio, go to `Test` > `Run All Tests` or press `Ctrl+R, A`.

![Test Succesfully](https://github.com/jlavandier/OldPhonePadCodingChallenge/blob/master/Test%20Succesfully.png?raw=true)
   
# Contributing
Contributions are welcome! Please fork the repo and open a pull request to add functionality or to fix bugs as necessary.
