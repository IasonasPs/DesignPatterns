using System;

namespace Strategy.FirstTry
{
    //Concrete Strategy
    internal class Zip : ICompression
    {
        public void Compress(string compressedFileFileName)
        {
            Console.WriteLine("Folder is compressed using zip approach: '"
                + compressedFileFileName +
                ".zip' file is created");
        }
    }
}
