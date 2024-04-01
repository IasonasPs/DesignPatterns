namespace Strategy._2nd
{
    internal class JuniorDevSalaryCalculator : ISalaryCalculator   //Concrete strategy
    {

        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports)
            => reports.Where(r => r.Level == DeveloperLevel.Junior).Select(r => r.CalculateSalary()).Sum();
    }
}
