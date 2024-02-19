namespace Stringg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Azubuike Kevin ";
            Console.WriteLine("Trim '{0}'", fullName.Trim());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First name: "+ firstName);
            Console.WriteLine("Last name: "+ lastName);

            // Split Method 
            var names = fullName.Split(' ');
            Console.WriteLine("First name: " + names[0]);
            Console.WriteLine("Last name: " + names[1]);

            
            Console.WriteLine(fullName.Replace("Kevin", "Okolie"));

            if (string.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 20.34f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
