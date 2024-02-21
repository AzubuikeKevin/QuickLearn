namespace Constructr
{
    public partial class Program
    {
        static void Main(string[] args)
        {
           var customer = new Customer();
           var customer1 = new Customer()
           {
               Id = 1,
               Name = "Test",
           };
            Console.WriteLine("Customer 1: " + customer1.Name);
        }
    }
}
