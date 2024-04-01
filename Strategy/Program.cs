using Microsoft.Extensions.DependencyInjection;
using Strategy._2nd;
using Strategy._3d_Example;
using Strategy.FirstTry;
using DeveloperReport = Strategy._2nd.DeveloperReport;


namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!");

            //FirstTryMain();
            SecondTryMain();
            //ThirdTryMain();
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
        public static void SecondTryMain()
        {

            var reports = new List<DeveloperReport>()
            {
                new DeveloperReport {  Id = 1, Name = "Dev1" , Level = DeveloperLevel.Junior , HourlyRate = 4.0 , WorkingHours = 100},
                new DeveloperReport {  Id = 2, Name = "Dev2" , Level = DeveloperLevel.Junior , HourlyRate = 4.0 , WorkingHours = 100},
                new DeveloperReport {  Id = 3, Name = "Dev3" , Level = DeveloperLevel.Senior , HourlyRate = 22.0 , WorkingHours = 100},
                new DeveloperReport {  Id = 4, Name = "Dev4" , Level = DeveloperLevel.Senior , HourlyRate = 22.0 , WorkingHours = 100},
            };

            SalaryCalculator salaryCalculator = new SalaryCalculator(new JuniorDevSalaryCalculator());

            double t =  salaryCalculator.Calculate(reports);
            Console.WriteLine(t);

            salaryCalculator.SetCalculator(new SeniorDevSalaryCalculator());

            double s = salaryCalculator.Calculate(reports);
            Console.WriteLine(s);

        }
        public static void ThirdTryMain()
        {
            ServiceProvider serviceProvider = new  ServiceCollection()
                .AddScoped<IMovieStrategy,M>()
                .AddScoped<Context>()
                .BuildServiceProvider();


        }
    }



}

