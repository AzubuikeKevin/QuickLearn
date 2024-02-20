namespace DirectoryandDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\temp\folder2", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\dev1\folder", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories) 
                Console.WriteLine(File.ReadAllText(directory));

            Directory.Exists("..");


            // Directory Info
            var directoryInfo = new DirectoryInfo("");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
