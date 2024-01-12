// See https://aka.ms/new-console-template for more information
byte number = 0;

var count = 10;
var totalPrice = 23.5f;
var character = 'A';
var firstName = "Azubuike";
var isWorking = true;

Console.WriteLine(number);
Console.WriteLine(count);
Console.WriteLine(totalPrice);
Console.WriteLine(character);
Console.WriteLine(firstName);
Console.WriteLine(isWorking);
Console.BackgroundColor = ConsoleColor.Green;

// Format String
Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

// Constants

const float Pi = 3.142f;
Console.WriteLine(Pi * 2 + 5);