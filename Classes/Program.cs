
// See https://aka.ms/new-console-template for more information
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