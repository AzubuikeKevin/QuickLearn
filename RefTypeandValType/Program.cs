namespace RefTypeandValType
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 10; 
            var b = a;
            b++;

            Console.WriteLine("a: {0} b: {1}", a , b);

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 10;

            Console.WriteLine(string.Format("Array1[0] {0}, Array2[0] {1}", array1[0], array2[0]));
        } 
    }
}
