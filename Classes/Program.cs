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
public class Program
{
    public static void Main(string[] args)
    {
        var person = new Person();
        person.FirstName = "Azubuike";
        person.Introduce();

        int result = Calculator.Add(2, 4);
        Console.WriteLine(result);
    }
}