namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Azubuike";
            var lastName = "Kevin";

            var fullName = firstName + " " + lastName;
            var myfullName = string.Format("My name is {0} {1}", lastName, firstName);
            Console.WriteLine(fullName);
            Console.WriteLine(myfullName);

            var numbers = new int[4] { 1, 2, 3,4};
            string list = string.Join(" | ", numbers);
            Console.WriteLine("These are the list of numbers \n" + list);
        }
    }
}
