// See https://aka.ms/new-console-template for more information
try
{
	var number = "Hello You!";
	byte b = Convert.ToByte(number);
    Console.WriteLine(number);
}
catch (Exception)
{

    Console.WriteLine("Unable to convert the number to byte");
}

