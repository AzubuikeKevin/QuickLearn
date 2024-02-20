using System.Text;

namespace StrBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10)
                    .AppendLine()
                    .Append("Header")
                    .AppendLine()
                    .Append('-', 10)

                    .Replace('-', '+')
                    .Remove(0, 10)
                    .Insert(0, new string('-', 10));
            Console.WriteLine(builder);
        }
    }
}
