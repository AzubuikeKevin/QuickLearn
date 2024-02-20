namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 3, 4, 7 };
            numbers.Add(1);

            numbers.AddRange(new int[3] { 3, 5, 0 });

            foreach (int i in numbers)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] ==1)
                {
                    numbers.Remove(1);
                }
                foreach (var j in numbers)
                Console.WriteLine(j);
            }

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
