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


    public interface ITest
    {
        int num { get; set; }
    }

    public interface ITest2 : ITest
    {
        string text { get; set; }
    }

    public interface ITest3 : ITest2
    {
        double d { get; set; }
    }

    public class myNUmber : ITest3
    {
    }

}
