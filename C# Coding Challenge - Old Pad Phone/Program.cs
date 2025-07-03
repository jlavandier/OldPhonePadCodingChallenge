using C__Coding_Challenge___Old_Pad_Phone.Services;
using System;

Console.WriteLine("Hello, Iron Software");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("This is the simulation of Old Pad Phone");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("Allowed inputs: 0-9, *, #");
Console.WriteLine("KeyPad:\n" +
    "{'1',  \"&'(\"}\n" +
    "{'2', \"ABC\"}\n" +
    "{'3', \"DEF\"}\n" +
    "{'4', \"GHI\"}\n" +
    "{'5', \"JKL\"}\n" +
    "{'6', \"MNO\"} \n" +
    "{'7', \"PQRS\"} \n" +
    "{'8', \"TUV\"}\n" +
    "{'9', \"WXYZ\"}\n" +
    "{'0', \"BackSpace\"}\n" +
    "{'#', \"Enter\"}\n" +
    "{'*', \"BackSpace\"}");

// Testing...
Console.WriteLine("\n---------------------------------------------");
Console.WriteLine("\nTesting");
Console.WriteLine(PhonePadController.OldPhonePad("222 2 22#")); // "CAB"
Console.WriteLine(PhonePadController.OldPhonePad("44 33 555 555 666 010 9 666 777 555 3#")); // "HELLO & WORLD"
Console.WriteLine(PhonePadController.OldPhonePad("444 777 666 66 0 7777 666 333 8 9 2 777 33#")); // "IRON SOFTWARE"

Console.WriteLine(PhonePadController.OldPhonePad("8 33 7777 8 444 66 4")); // Not return because # is missing
Console.WriteLine(PhonePadController.OldPhonePad("8 33 7777 8 444 66 4#")); // "TESTING"
