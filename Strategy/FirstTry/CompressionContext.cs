using System;
namespace Strategy.FirstTry
{
    internal class CompressionContext
    {
        //The context provides the interface which is going to be used by the Client.
        //But it does not know the concrete class that it will use.
        //It should be able to work with any strategy (aka with any solid implementation of the behavior
        //defined in the interface class)...!
        private ICompression Compression;

        public CompressionContext(ICompression compression)
        {
                this.Compression = compression;
        }

        //A setter method is provided to change the strategy at runtime
        public void SetStrategy(ICompression compression)
        {
            this.Compression = compression;
        }

        public void CreateFile(string compressedFileFileName)
        {
            Compression.Compress(compressedFileFileName);
        }
    }
}
