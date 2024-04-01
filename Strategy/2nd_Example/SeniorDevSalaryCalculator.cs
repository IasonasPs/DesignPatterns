namespace Strategy._2nd
{
    internal class SeniorDevSalaryCalculator : ISalaryCalculator //Concrete Strategy
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports)
            => reports.Where(r => r.Level == DeveloperLevel.Senior).Select(r => r.CalculateSalary()).Sum();
    }
}
