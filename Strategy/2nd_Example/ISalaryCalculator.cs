namespace Strategy._2nd
{
    internal interface ISalaryCalculator    // Strategy interface
    {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}
