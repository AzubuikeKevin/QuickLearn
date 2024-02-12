
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
