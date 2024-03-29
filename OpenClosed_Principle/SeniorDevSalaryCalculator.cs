using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
