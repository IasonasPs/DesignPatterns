namespace OpenClosed_Principle
{
    internal class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation;

        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerCalculation)
        {
            _developerCalculation=developerCalculation;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var item in _developerCalculation)
            {
                totalSalaries += item.CalculateSalary();
            }

            return totalSalaries;
        }

    }
}
