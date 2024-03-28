using Strategy.FirstTry;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            FirstTryMain();
        }

        public static void FirstTryMain()
        {
            ICompression strategy = new Zip();

            CompressionContext context = new CompressionContext(strategy);
            
            context.CreateFile("Test");

            context.SetStrategy(new Rar());

            context.CreateFile("Test");

            Console.ReadLine();
        }
    }
}
