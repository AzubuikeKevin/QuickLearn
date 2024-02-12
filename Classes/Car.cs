
// See https://aka.ms/new-console-template for more information


public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Colour { get; set; }

    public void GetCarName()
    {
        Console.WriteLine("The Brand of my car is " + Brand + " & it is a " + Model + " with a " + Colour + " stripe.");
    }
}
