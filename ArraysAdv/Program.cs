namespace ArraysAdv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length :" + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 is " + index);

            // Clear
            Array.Clear(numbers, 0, 4);
            Console.WriteLine("Effect of clear");
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            // Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy");
            foreach (var l in another)
            {
                Console.WriteLine(l);
            }

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // Reverse ()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
