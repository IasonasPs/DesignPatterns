using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._2nd
{
    internal interface ISalaryCalculator    // Strategy interface
    {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}
