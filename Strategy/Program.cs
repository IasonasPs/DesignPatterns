using OpenClosed_Principle;
using Strategy._2nd;
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
            };


            JuniorDevSalaryCalculator juniorDevSalaryCalculator = new JuniorDevSalaryCalculator();
            SeniorDevSalaryCalculator seniorDevSalaryCalculator = new SeniorDevSalaryCalculator();


            var juniorTotal = juniorDevSalaryCalculator.CalculateTotalSalary(reports);

            var seniortotal = seniorDevSalaryCalculator.CalculateTotalSalary(reports);

            Console.WriteLine(juniorTotal + seniortotal);
        }
    }
}

