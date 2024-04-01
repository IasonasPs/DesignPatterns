namespace Strategy._2nd
{
    internal class SalaryCalculator // Context 
    {
        private ISalaryCalculator _calculator;  // and thats the reference to a strategy Object

        public SalaryCalculator(ISalaryCalculator calculator)
        {
            _calculator=calculator;
        }

        public void SetCalculator(ISalaryCalculator calculator) => _calculator = calculator;

        public double Calculate(IEnumerable<DeveloperReport> reports) => _calculator.CalculateTotalSalary(reports);
    }
}
