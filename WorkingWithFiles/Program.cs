namespace WorkingWithFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\folder\asset.jpg", path, true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            //File Info (would have to create an Object)
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}
