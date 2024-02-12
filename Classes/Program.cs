// See https://aka.ms/new-console-template for more information
public class Person
{
    public string FirstName { get; set; }
    public string LastName = "Kevin";

    public void Introduce()
    {
        Console.WriteLine("Hello my name is " + FirstName);
    }
}

public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

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

public class Age
{
    public string FullName { get; set; }

    public void getAge(int DateOfBirth, int Year)
    {
        var age =  Year - DateOfBirth;
        Console.WriteLine("Hello " + FullName + " your age is " + age);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        var person = new Person();
        person.FirstName = "Azubuike";
        person.Introduce();

        int result = Calculator.Add(2, 4);
        Console.WriteLine(result);

        var car = new Car();
        car.Brand = "Toyota";
        car.Model = "Camry";
        car.Colour = "Red";
        car.GetCarName();

        var age = new Age();
        age.FullName = "Kevin Okolie";
        age.getAge(1995, 2024);
    }
}