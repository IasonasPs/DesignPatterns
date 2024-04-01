namespace Strategy.FirstTry
{
    //Concrete Strategy 
    internal class Rar : ICompression
    {
        public void Compress(string compressedFileFileName)
        {
            Console.WriteLine("Folder is compressed using rar approach :'" +
                compressedFileFileName + ".rar' file is created");
        }
    }
}
