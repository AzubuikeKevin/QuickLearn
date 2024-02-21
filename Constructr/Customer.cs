namespace Constructr
{
    public partial class Program
    {
        public class Customer
        {
            public int Id;
            public string Name;

            public Customer()
            {
                
            }

            public Customer(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public Customer(string name)
            {
                Name = name;
            }
        }

    }

}
