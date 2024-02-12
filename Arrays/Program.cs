namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);

            var flags = new Boolean[3];
            flags[0] = true;

            Console.WriteLine(flags[2]);

            var colours = new string[4];

            colours[0] = "Red";
            colours[1] = "Blue";

            Console.WriteLine(colours[0]);
            Console.WriteLine(colours[1]);


            var cars = new string[4] {"Toyota", "Nissan", "Lexus", "Mercedes"};
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);
            Console.WriteLine(cars.Length);
            Console.WriteLine(cars[0].ToLower());
        }
    }
}
