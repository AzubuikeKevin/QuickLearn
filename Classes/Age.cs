
// See https://aka.ms/new-console-template for more information



public class Age
{
    public string FullName { get; set; }

    public void getAge(int DateOfBirth, int Year)
    {
        var age =  Year - DateOfBirth;
        Console.WriteLine("Hello " + FullName + " your age is " + age);
    }
}
