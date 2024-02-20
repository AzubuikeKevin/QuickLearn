namespace DataTyme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2023, 12, 04);
            Console.WriteLine(dateTime);

            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(today.ToShortDateString());
            Console.WriteLine(today.ToLongTimeString());
            Console.WriteLine(today.ToShortTimeString());
            Console.WriteLine(today.ToString("D"));
        }
    }
}
