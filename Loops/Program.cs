namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var name = "Okolie Azubuike";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var number = new int[3] { 1, 2, 3 };

            foreach (var character in number)
            {
                Console.WriteLine(character);
            }

            var l = 0;
            while (l <= 10)
            {
                if (l % 2 == 0)
                {
                    Console.WriteLine(l);
                    l++;
                }
            }

            while (true)
            {
                Console.WriteLine("Enter your name: ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;

            }
        }
    }
}