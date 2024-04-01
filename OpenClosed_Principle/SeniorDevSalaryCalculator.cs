namespace OpenClosed_Principle
{
    internal class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
                
        }
        public override double CalculateSalary() 
            => DeveloperReport.HourlyRate*DeveloperReport.WorkingHours;
    }
}
