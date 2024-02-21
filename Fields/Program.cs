namespace Fields
{
    public class Program
    {
        public class Person
        {
            public int Id;
            public string Name;
            public readonly List<Order> Orders = new List<Order>();

            public Person(int id)
            {
                  Id = id;
            }

            public Person(int id, string name)
                : this(id)
            {
                Name = name;
            }

            public void promote()
            {
              
            }
        }

        public class  Order
        {
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var person = new Person(1);
            person.Orders.Add(new Order());
            person.Orders.Add(new Order());

            person.promote();
            Console.WriteLine(person.Orders.Count);
            
        }
    }
}
