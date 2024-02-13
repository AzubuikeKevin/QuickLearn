namespace ConditionalStatements
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = true;

            float price = (isGoldCustomer) ? 23.45f : 45.34f;
            Console.WriteLine(price);

            var season = Season.Winter;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its autumn and a beautiful season");
                    break;
                case Season.Spring:
                    Console.WriteLine("Its Spring and a beautiful season");
                    break;
                case Season.Winter:
                case Season.Summer:
                    Console.WriteLine("Its a perfect time to visit the beach");
                    break;

                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }
        }
    }
}
