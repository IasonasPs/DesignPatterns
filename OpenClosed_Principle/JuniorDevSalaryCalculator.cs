namespace OpenClosed_Principle
{
    internal class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }
        #region
        //public override double CalculateSalary()
        //{
        //    return DeveloperReport.HourlyRate*DeveloperReport.WorkingHours;
        //}
        #endregion

        public override double CalculateSalary() => 
            DeveloperReport.HourlyRate*DeveloperReport.WorkingHours;
    }
}
